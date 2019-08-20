using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Stats
    {

        //Dictionary of the stats, with the key as a string representing the name of the skill, and int being the level in the stat
        public int[] stats;

        public static int getStatsIndex(string temp)
        {
            switch (temp)
            {
                case "INT":
                    return 0;
                case "REF":
                    return 1;
                case "CL":
                    return 2;
                case "TECH":
                    return 3;
                case "LK":
                    return 4;
                case "ATT":
                    return 5;
                case "MA":
                    return 6;
                case "EM":
                    return 7;
                case "BTM":
                    return 8;
            }
            return 0;
        }

        public int getStats(string temp)
        {
            switch(temp) {
                case "INT":
                    return stats[0];
                case "REF":
                    return stats[1];
                case "CL":
                    return stats[2];
                case "TECH":
                    return stats[3];
                case "LK":
                    return stats[4];
                case "ATT":
                    return stats[5];
                case "MA":
                    return stats[6];
                case "EM":
                    return stats[7];
                case "BTM":
                    return stats[8];
            }
            return stats[0];
        }

            

        //Double to keep track of lost humanity
        double humanityLost = 0;

        //Property for finding Empathy
        public int EM
        {
            
            get
            {
                return stats[getStatsIndex("EM")] - Convert.ToInt32(Math.Floor(humanityLost)) / 10;
            }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                stats[getStatsIndex("EM")] = value;
            }
        }
        public double Humanity
        {
            get
            {
                return stats[getStatsIndex("EM")] * 4 - humanityLost;
            }
            set
            {
                if(value < Humanity)
                {
                    humanityLost += Humanity - value;
                }
            }
        }

		public double Run
		{
			get
			{
				return stats[getStatsIndex("MA")] * 3;
			}
		}

		public double Leap
		{
			get
			{
				return Run / 4;
			}
		}

        public static Stats generateStatsForNPC(int points, Character npc)
        {
            Random rnd = new Random();
            int random = rnd.Next(6, 8);
            Stats temp = new Stats();
            temp.stats = Utility.GetSlots(9, 10);
            
            

            return temp;

        }
    }
}
