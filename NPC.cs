using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class NPC
    {
        public string name;
        public bool male;
        public Role role;
        public Stats stats = new Stats();
        public Style style;
        public Motivation motivation;

        public NPC()
        {
            this = generateStatsForNPC();
        }

        
        /// <summary>
        /// NPC Constructor, takes int for how many points NPC gets for stats, if stats are 20 or less, they are randomly generated between 35-65
        /// </summary>
        NPC(int points)
        {
            if (points <= 20)
            {
                this.generateRandomNPC(0);
            } 
            else
            {
                this.generateRandomNPC(points);
            }
            
        }

        /// <summary>
        /// Generates random NPC using all of the other functions in this class
        /// </summary>
        /// <returns>NPC</returns>
        public static NPC generateRandomNPC(int points)
        {
            NPC temp = new NPC();
            Random rnd = new Random();
            if (rnd.Next(1,10) < 6)
            {
                male = false;
            }
            temp.name = RandomNameGenerator(male);
            
            if (points == 0)
            {
                points = rnd.Next(30, 65);
            }
            temp.style.randomlySelectStyle();
            temp.motivation = Motivation.randomlyGenerateMotivation();
            rnd.Next(1, 10);
            temp.role = Role.roles[Role.intToRoleName(rnd.Next(1, 10))];
            temp.stats = generateStatsForNPC(points);

        }

        /// <summary>
        /// Randomly generates a name based on if the name needed is male or not
        /// </summary>
        /// <returns>string</returns>
        static string RandomNameGenerator (bool male)
        {
            string name = "";
            Random rnd = new Random();
            int random = rnd.Next(1,1002);
            if (male)
            {
                name = System.IO.File.ReadAllLines("MaleNames.txt")[random].Trim(); 
            }
            else
            {
                name = System.IO.File.ReadAllLines("FemaleNames.txt")[random].Trim();
            }
            random = rnd.Next(1, 972);
            name += " " + System.IO.File.ReadAllLines("Surnames.txt")[random].Trim();
            return name;
        }

        /// <summary>
        /// Randomly generates a name without thinking about gender
        /// </summary>
        /// <returns>string</returns>
        static string RandomNameGenerator()
        {
            string name = "";
            Random rnd = new Random();
            int random = rnd.Next(1, 2004);
            if (random < 1003)
            {
                name = System.IO.File.ReadAllLines("MaleNames.txt")[random].Trim();
            }
            else
            {
                name = System.IO.File.ReadAllLines("FemaleNames.txt")[random-1002].Trim();
            }
            random = rnd.Next(1, 972);
            name += " " + System.IO.File.ReadAllLines("Surnames.txt")[random].Trim();
            return name;
        }

        /// <summary>
        /// Generates stats for NPC, based on the role's most important stat, all other stats are randomly distributed
        /// </summary>
        /// <returns>Stats class</returns>
        Stats generateStatsForNPC(int points)
        {
            Random rnd = new Random();
            int random = rnd.Next(6, 8);
            Stats temp = new Stats();
            temp.stats[role.importantStat] = random;
            points -= random;

            foreach(KeyValuePair<string, int> key in temp.stats)
            {
                if (key.Key != role.importantStat)
                {
                    bool run = true;
                    while (run)
                    {
                        if (points % 8 == 0)
                        {
                            temp.stats[key.Key] += points / 8;
                            run = false;
                        }
                        else if (temp.stats[key.Key] == 10)
                        {
                            run = false;
                        }
                        else
                        {
                            points -= 1;
                            temp.stats[key.Key] += 1;
                        }
                    }

                }
            }
            return temp;
            
        }
    }
}
