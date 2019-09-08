using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Cyberpunk2020CharacterCreator.Utility;

namespace Cyberpunk2020CharacterCreator
{
    class Role
    {
        // Makes a Dictionary full of all the roles with the name of the role as the string key
        public static Dictionary<string, Role> roles = makeRoles();

        public string name
        {
            get;
            private set;
        }
        public string desc
        {
            get;
            private set;
        }
        public string[] skills
        {
            get;
            private set;
        }

        //Not needed anymore
        public static string intToRoleName(int number)
        {
            switch(number)
            {
                case 1:
                    return "Solo";
                    
                case 2:
                    return "Rocker";
                    
                case 3:
                    return "Netrunner";
                    
                case 4:
                    return "Media";
                    
                case 5:
                    return "Nomad";
                    
                case 6:
                    return "Fixer";
                    
                case 7:
                    return "Cop";
                    
                case 8:
                    return "Corp";
                    
                case 9:
                    return "Techie";
                    
                case 10:
                    return "Medtechie";
                default:
                    return "Solo";
            }
        }

        static Dictionary<string, Role> makeRoles()
        {
            Dictionary<string, Role> roles = new Dictionary<string, Role>();

            string[] lines = System.IO.File.ReadAllLines("roles.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                Role role = new Role();
                //Checks for empty line
                if (lines[i].Trim() != "")
                {
                    //In the text file the line above the empty one are the base skills, so checks that this is not base skills
                    if (i+1 != lines.Length && lines[i + 1].Trim() != "")
                    {
                        //if not base skills, reads txt file to make the different roles/class's
                        role.name = line.Substring(0, line.IndexOf('(')).Trim();
                        string temp = line.Substring(line.IndexOf('(') + 1);
                        temp = temp.Substring(0, temp.IndexOf(')'));
                        temp = line.Substring(line.IndexOf(')') + 1);
                        role.desc = temp.Trim();
                        role.skills = lines[i + 1].Split(',');

                        roles.Add(role.name.ToLower(), role);

                    }
                }
            }
            return roles;
        }
        Dictionary<string,Role> XMLDocToDictionaryStringRole(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            Dictionary<string, Role> temp = new Dictionary<string, Role>();

            XmlNodeList list = doc.SelectNodes("role");
            foreach (XmlNode node in list)
            {
                Role tempRole = new Role();
                tempRole.name = XmlRemoveAllChildren(node,"name").InnerText;
                tempRole.desc = XmlRemoveAllChildren(node, "desc").InnerText;
                tempRole.skills = XmlRemoveAllChildren(node, "skills").InnerText.Split(',');

                temp.Add(tempRole.name,tempRole);
            }


            return temp;
        }   
     

    }
}
