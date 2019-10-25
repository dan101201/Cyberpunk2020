using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Stats
    {

        int[] _stats = new int[9];

        public int this[int i]
        {
            get
            {
                return _stats[i];
            }
            set
            {
                _stats[i] = value;
            }
        }

        public int Int
        {
            get
            {
                return _stats[0];
            }
            set
            {
                _stats[0] = value;
            }
        }
        public int Ref
        {
            get
            {
                return _stats[1];
            }
            set
            {
                _stats[1] = value;
            }
        }
        public int Cl
        {
            get
            {
                return _stats[2];
            }
            set
            {
                _stats[2] = value;
            }
        }
        public int Tech
        {
            get
            {
                return _stats[3];
            }
            set
            {
                _stats[3] = value;
            }
        }
        public int Lk
        {
            get
            {
                return _stats[4];
            }
            set
            {
                _stats[4] = value;
            }
        }
        public int Att
        {
            get
            {
                return _stats[5];
            }
            set
            {
                _stats[5] = value;
            }
        }
        public int Ma
        {
            get
            {
                return _stats[6];
            }
            set
            {
                _stats[6] = value;
            }
        }
        public int Em
        {

            get
            {
                return _stats[7] - Convert.ToInt32(Math.Floor(_humanityLost)) / 10;
            }
            set
            {
                _stats[7] = value;
            }
        }
        public int Bt
        {
            get
            {
                return _stats[8];
            }
            set
            {
                _stats[8] = value;
            }
        }
        public int Btm
        {
            get
            {
                return _stats[8];
            }
        }

        //Double to keep track of lost humanity
        double _humanityLost = 0;
        public double Humanity
        {
            get
            {
                return _stats[7] * 4 - _humanityLost;
            }
            set
            {
                if(value < Humanity)
                {
                    _humanityLost += Humanity - value;
                }
            }
        }

		public double Run
		{
			get
			{
				return _stats[6] * 3;
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
                return Bt * 10;
            }
        }

        public static Stats GenerateStatsForNpc(int points, Character npc)
        {
            Stats temp = new Stats();
            temp._stats = Utility.GetSlots(9, 10);
            
            return temp;
        }

        public int ToIndex(string temp)
        {
            switch (temp)
            {
                case "INT":
                    return _stats[0];
                case "REF":
                    return _stats[1];
                case "CL":
                    return _stats[2];
                case "TECH":
                    return _stats[3];
                case "LK":
                    return _stats[4];
                case "ATT":
                    return _stats[5];
                case "MA":
                    return _stats[6];
                case "EM":
                    return _stats[7];
                case "BTM":
                    return _stats[8];
            }
            return _stats[0];
        }

    }
}
