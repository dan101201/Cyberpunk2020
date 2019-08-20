using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cyberpunk2020CharacterCreator
{
    class Role
    {
        // Makes a Dictionary full of all the roles with the name of the role as the string key
        public static Dictionary<string, Role> roles
        {
            get
            {
                return makeRoles();
            }
        }

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

        Dictionary<string,Role> XMLDocToDictionaryStringRole(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            Dictionary<string, Role> temp = new Dictionary<string, Role>();

            XmlNodeList list = doc.SelectNodes("role");
            foreach (XmlNode node in list)
            {
                Role tempRole = new Role();
                
            }



            return temp;
        }   
     

    }
}
