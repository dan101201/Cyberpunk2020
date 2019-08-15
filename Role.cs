using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Role
    {
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
        public string[] jobNames
        {
            get;
            private set;
        }
        public string[] skills
        {
            get;
            private set;
        }
        public string specialAbility
        {
            get;
            private set;
        }
        //Only used for NPC's
        public string importantStat
        {
            get;
            private set;
        }

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
            Dictionary<string,Role> roles = new Dictionary<string,Role>();

            string[] lines = System.IO.File.ReadAllLines("roles.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                Role role = new Role();
                if (lines[i].Trim() != "")
                {
                    if (lines[i + 1].Trim() != "")
                    {
                        role.name = line.Substring(0,line.IndexOf('('));
                        string temp = line.Substring(line.IndexOf('(') + 1);
                        temp = temp.Substring(0, temp.IndexOf(')'));
                        role.jobNames = temp.Split(',');
                        temp = line.Substring(line.IndexOf(')') + 1);
                        temp = temp.Substring(0, temp.IndexOf("SA"));
                        role.desc = temp.Trim();
                        role.specialAbility = line.Substring(line.IndexOf("SA") + 2).Trim();
                        role.skills = lines[i + 1].Split(',');

                        roles.Add(role.name.ToLower(),role);
                        switch (role.name.Trim())
                        {
                            case "Techie":
                                role.importantStat = "TECH";
                                
                                break;
                            case "Solo":
                                role.importantStat = "REF";
                                
                                break;
                            case "Cop":
                                role.importantStat = "REF";
                                
                                break;
                            case "Nomad":
                                role.importantStat = "REF";
                                
                                break;
                            case "Rocker":
                                role.importantStat = "REF";
                                
                                break;
                            case "Corp":
                                role.importantStat = "INT";
                                
                                break;
                            case "Medtechie":
                                role.importantStat = "INT";
                                
                                break;
                            case "Netrunner":
                                role.importantStat = "INT";
                                
                                break;
                            case "Fixer":
                                role.importantStat = "CL";
                                
                                break;
                            case "Media":
                                role.importantStat = "ATT";
                                
                                break;
                        }
                    }
                }
            }
            return roles;
        }

    }
}
