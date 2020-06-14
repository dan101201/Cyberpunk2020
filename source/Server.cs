using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CyberpunkWebsite.Backend
{
    [Serializable]
    class UserAlreadyExistException : ApplicationException
    {
        public UserAlreadyExistException() { }
    }

    [Serializable]
    class UserDoesNotExistException : ApplicationException
    {
        public UserDoesNotExistException() { }
    }

    [Serializable]
    class HashCakeNotFoundException : ApplicationException
    {
        public HashCakeNotFoundException() { }
    }

    [Serializable]
    class ReaderEmptyException : ApplicationException
    {
        public ReaderEmptyException() { }
    }

    [Serializable]
    public class UserDoesNotHaveAnyCharactersException : ApplicationException
    {
        public UserDoesNotHaveAnyCharactersException() { }
    }

    public static class Server
    {
        public static bool noCharacters = false;

        private readonly static string connectionString = "Server=tcp:cyberpunk.database.windows.net,1433;Initial Catalog=data;Persist Security Info=False;User ID=dan101201;Password=D52QwF2vRO81;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private static short[] characterIds;
        private static string username;
        private static void SplitHashCake(byte[] hashCake, out byte[] salt, out byte[] hash)
        {
            salt = new byte[1024];
            hash = new byte[1024];
            Array.Copy(hashCake, salt, salt.Length);
            Array.Copy(hashCake, salt.Length, hash, 0, hash.Length);
        }

        private static short[] SplitCharacterIdBytes(byte[] byteArr)
        {
            List<short> Ids = new List<short>();
            for (int i = 0; i < byteArr.Length; i+=2)
            {
                byte[] tempArr = new byte[2];
                Array.Copy(byteArr,i, tempArr,0, 2);
                Ids.Add(Convert.ToInt16(tempArr));
            }
            return Ids.ToArray();
        }

        private static void GetBinarySaltFromDatabase(string username, out byte[] salt, out byte[] hash)
        {
            salt = new byte[1024];
            hash = new byte[1024];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Table] WHERE username=@Name", con))
                {
                    cmd.Parameters.AddWithValue("Name", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                if (((string)reader[0]) == username)
                                {
                                    SplitHashCake((byte[])reader[1], out salt, out hash);
                                    characterIds = SplitCharacterIdBytes((byte[])reader[2]);
                                    return;
                                }
                            }
                        }
                        else
                        {
                            //Throws exception if no users are found at all
                            throw new UserDoesNotExistException();
                        }
                    } // reader closed and disposed here
                } // command disposed here
            } //connection closed and disposed here

            //Only gets thrown if neither ReaderEmptyException nor UserDoesNotExistException gets thrown
            throw new HashCakeNotFoundException();
        }

        public static byte[] GenerateSaltedPassword(string password, byte[] salt)
        {
            Rfc2898DeriveBytes hashingAlgorithm = new Rfc2898DeriveBytes(password, salt, 20000);

            byte[] hash = hashingAlgorithm.GetBytes(1024);
            byte[] hashCake = new byte[2048];
            Array.Copy(salt, hashCake, 0);
            Array.Copy(hash, hashCake, salt.Length);

            return hashCake;
        }

        public static bool PasswordValidation(string username, string password)
        {
            byte[] salt, databaseHash, generatedHashCake, generatedHash = new byte[1024];
            GetBinarySaltFromDatabase(username.Trim(), out salt, out databaseHash);
            generatedHashCake = GenerateSaltedPassword(password, salt);
            SplitHashCake(generatedHashCake, out _, out generatedHash);
            return databaseHash == generatedHash;
        }

        public static byte[] GenerateNewSaltedPassword(string password)
        {
            byte[] salt = new byte[1024];
            new RNGCryptoServiceProvider().GetBytes(salt);
            Rfc2898DeriveBytes hashingAlgorithm = new Rfc2898DeriveBytes(password, salt, 20000);

            byte[] hash = hashingAlgorithm.GetBytes(1024);
            byte[] hashCake = new byte[2048];
            Array.Copy(salt, hashCake, 0);
            Array.Copy(hash, hashCake, salt.Length);

            return hashCake;
        }

        public static void AddUserToDatabase(string username, string password)
        {
            username = username.Trim();
            byte[] hashCake = GenerateNewSaltedPassword(password);
            SqlParameter[] myparm = new SqlParameter[2];
            myparm[0] = new SqlParameter("@User", username);
            myparm[1] = new SqlParameter("@Pass", hashCake);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string temp = "SELECT COUNT(*) from [dbo].[table] WHERE username LIKE '@User'";
                SqlCommand command = new SqlCommand(temp, connection);
                command.Connection.Open();
                int userCount = (int)command.ExecuteScalar();
                if (userCount > 0)
                {
                    throw new UserAlreadyExistException();
                }
            }

            string tempCommand = "INSERT INTO [dbo].[Table] VALUES (@User,@Pass,'none')";
            CreateAddUserCommand(tempCommand, username, hashCake);
        }

        static short AddCharacterToDatabase(Character c)
        {
            byte[] bytes;
            IFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, c);
                bytes = stream.ToArray();
            }
            short highestId;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT MAX(id) FROM [characters].[Table]";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader == null)
                        {
                            highestId = 0;
                        }
                        else
                        {
                            highestId = (short)reader[0];
                        }
                    }
                }
                queryString = "INSERT INTO [characters].[Table] VALUES(@id,@character)";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("id", highestId);
                    command.Parameters.AddWithValue("character", bytes);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            return highestId;
        }

        private static void CreateAddUserCommand(string queryString, string username, byte[] hashCake)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("User", username);
                    command.Parameters.AddWithValue("Pass", hashCake);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        internal static Character[] Characters
        {
            get
            {
                try
                {
                    return Server.GetCharactersFromDatabase().Where(x => !x.NPC).ToArray();
                }
                catch (UserDoesNotHaveAnyCharactersException)
                {
                    return new Character[0];
                    //Boom boom sad no character cry
                }
            }
        }
        internal static Character[] NPCs
        {
            get
            {
                try
                {
                    return Server.GetCharactersFromDatabase().Where(x => x.NPC).ToArray();
                }
                catch (UserDoesNotHaveAnyCharactersException)
                {
                    return new Character[0];
                    //Boom boom sad no character cry
                }
            }
        }

        internal static List<Character> GetCharactersFromDatabase()
        {
            List<Character> chars = new List<Character>();
            List<int> charIds = new List<int>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [names].[Table]", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                foreach (int id in charIds)
                                {
                                    if ((int)reader[0] == id)
                                    {
                                        IFormatter formatter = new BinaryFormatter();
                                        using (MemoryStream stream = new MemoryStream())
                                        {
                                            chars.Add((Character)formatter.Deserialize(stream));
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            throw new ArgumentException("Index dont match id's present in database");
                        }
                    } // reader closed and disposed here
                } // command disposed here
            } //connection closed and disposed here
            if (!chars.Any())
            {
                noCharacters = true;
                throw new UserDoesNotHaveAnyCharactersException();
            }
            return chars;
        }

    }
}
