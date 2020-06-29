using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Cyberpunk2020Library.Utility;

namespace Cyberpunk2020Library
{
    [Serializable]
    public class Role
    {
        // Makes a Dictionary full of all the roles with the name of the role as the string key
        public static Dictionary<string, Role> roles = MakeRoles();

        public string Name
        {
            get;
            private set;
        } = "";
        public string Desc
        {
            get;
            private set;
        } = "";
        public string[] Skills
        {
            get;
            private set;
        } = new string[0];

        //Not needed anymore
        public static string IntToRoleName(int number)
        {
            switch(number)
            {
                case 1:
                    return "solo";
                    
                case 2:
                    return "rocker";
                    
                case 3:
                    return "netrunner";
                    
                case 4:
                    return "media";
                    
                case 5:
                    return "nomad";
                    
                case 6:
                    return "fixer";
                    
                case 7:
                    return "cop";
                    
                case 8:
                    return "corp";
                    
                case 9:
                    return "techie";
                    
                case 10:
                    return "medtechie";
                default:
                    return "solo";
            }
        }

        static Dictionary<string, Role> MakeRoles()
        {
            Dictionary<string, Role> roles = new Dictionary<string, Role>();

            string[] lines = Properties.Resources.roles.Split('\n');

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
                        role.Name = line.Substring(0, line.IndexOf('(')).Trim();
                        string temp = line.Substring(line.IndexOf('(') + 1);
                        temp = temp.Substring(0, temp.IndexOf(')'));
                        temp = line.Substring(line.IndexOf(')') + 1);
                        role.Desc = temp.Trim();
                        role.Skills = lines[i + 1].Split(',');

                        roles.Add(role.Name.ToLower(), role);

                    }
                }
            }
            return roles;
        }
        static Dictionary<string,Role> XmlDocToDictionaryStringRole(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            Dictionary<string, Role> temp = new Dictionary<string, Role>();

            XmlNodeList list = doc.SelectNodes("role");
            foreach (XmlNode node in list)
            {
                Role tempRole = new Role();
                tempRole.Name = XmlRemoveAllChildren(node,"name").InnerText;
                tempRole.Desc = XmlRemoveAllChildren(node, "desc").InnerText;
                tempRole.Skills = XmlRemoveAllChildren(node, "skills").InnerText.Split(',');

                temp.Add(tempRole.Name,tempRole);
            }


            return temp;
        }   
     

    }
}
