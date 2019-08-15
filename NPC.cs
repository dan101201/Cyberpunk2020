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
            this.generateRandomNPC(0);
        }

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

        void generateRandomNPC(int points)
        {
            Random rnd = new Random();
            if (rnd.Next(1,10) < 6)
            {
                male = false;
            }
            name = RandomNameGenerator(male);
            
            if (points == 0)
            {
                points = rnd.Next(30, 65);
            }
            style.randomlySelectStyle();
            motivation = Motivation.randomlyGenerateMotivation();
            rnd.Next(1, 10);
            role = Role.roles[Role.intToRoleName(rnd.Next(1, 10))];
            stats = generateStatsForNPC(points);

        }

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
