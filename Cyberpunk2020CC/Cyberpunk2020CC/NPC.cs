﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class NPC
    {
        //Name for the NPC
        public string name;

        //If false, its female
        public bool male;

        //The class/role of the NPC
        public Role role;

        //Stats for the NPC
        public Stats stats = new Stats();

        //The NPC's Style
        public Style style;
        public Motivation motivation;

        /// <summary>
        /// Generates random NPC using all of the other functions in this class
        /// </summary>
        public NPC()
        {
        }


        /// <summary>
        /// Generates random NPC using all of the other functions in this class
        /// </summary>
        /// <returns>NPC</returns>
        static NPC generateRandomNPC(int points)
        {
            NPC temp = new NPC();
            Random rnd = new Random();
            if (rnd.Next(1,10) < 6)
            {
                temp.male = false;
            }
            temp.name = RandomNameGenerator(temp.male);
            
            if (points == 0)
            {
                points = rnd.Next(30, 65);
            }
            temp.style.randomlySelectStyle();
            temp.motivation = Motivation.randomlyGenerateMotivation();
            rnd.Next(1, 10);
            temp.role = Role.roles[Role.intToRoleName(rnd.Next(1, 10))];
            temp.stats = generateStatsForNPC(points, temp);

            return temp;
        }

        /// <summary>
        /// Randomly generates a name based on if the name needed is male or not
        /// </summary>
        /// <returns>string</returns>
        public static string RandomNameGenerator (bool male)
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
        public static string RandomNameGenerator()
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
        static Stats generateStatsForNPC(int points, NPC npc)
        {
            Random rnd = new Random();
            int random = rnd.Next(6, 8);
            Stats temp = new Stats();
            temp.stats[npc.role.importantStat] = random;
            points -= random;

            foreach(KeyValuePair<string, int> key in temp.stats)
            {
                if (key.Key != npc.role.importantStat)
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
