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

        public int INT
        {
            get
            {
                return stats[0];
            }
            private set
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
            private set
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
            private set
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
            private set
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
            private set
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
            private set
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
            private set
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
            private set
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
            private set
            {
                stats[8] = value;
            }
        }
        public int BTM
        {
            get
            {
                return stats[7];
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

        public static Stats generateStatsForNPC(int points, Character npc)
        {
            Stats temp = new Stats();
            temp.stats = Utility.GetSlots(9, 10);
            
            return temp;
        }
    }
}
