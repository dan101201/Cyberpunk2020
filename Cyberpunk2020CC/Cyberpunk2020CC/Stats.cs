using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Stats
    {

        int[] stats = new int[9];

        public int this[int i]
        {
            get
            {
                return stats[i];
            }
            set
            {
                stats[i] = value;
            }
        }

        public int INT
        {
            get
            {
                return stats[0];
            }
            set
            {
                stats[0] = value;
            }
        }
        public int REF
        {
            get
            {
                return stats[1];
            }
            set
            {
                stats[1] = value;
            }
        }
        public int CL
        {
            get
            {
                return stats[2];
            }
            set
            {
                stats[2] = value;
            }
        }
        public int TECH
        {
            get
            {
                return stats[3];
            }
            set
            {
                stats[3] = value;
            }
        }
        public int LK
        {
            get
            {
                return stats[4];
            }
            set
            {
                stats[4] = value;
            }
        }
        public int ATT
        {
            get
            {
                return stats[5];
            }
            set
            {
                stats[5] = value;
            }
        }
        public int MA
        {
            get
            {
                return stats[6];
            }
            set
            {
                stats[6] = value;
            }
        }
        public int EM
        {

            get
            {
                return stats[7] - Convert.ToInt32(Math.Floor(humanityLost)) / 10;
            }
            set
            {
                stats[7] = value;
            }
        }
        public int BT
        {
            get
            {
                return stats[8];
            }
            set
            {
                stats[8] = value;
            }
        }
        public int BTM
        {
            get
            {
                return stats[8];
            }
        }

        //Double to keep track of lost humanity
        double humanityLost = 0;
        public double Humanity
        {
            get
            {
                return stats[7] * 4 - humanityLost;
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
				return stats[6] * 3;
			}
		}

		public double Leap
		{
			get
			{
				return Run / 4;
			}
		}

        public int CarryWeight
        {
            get
            {
                return BT * 10;
            }
        }

        public static Stats generateStatsForNPC(int points, Character npc)
        {
            Stats temp = new Stats();
            temp.stats = Utility.GetSlots(9, 10);
            
            return temp;
        }

        public int ToIndex(string temp)
        {
            switch (temp)
            {
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

    }
}
