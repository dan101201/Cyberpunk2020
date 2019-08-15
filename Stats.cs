using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Stats
    {

        public Dictionary<string, int> stats = new Dictionary<string, int>();
        

        public Stats()
        {
            stats.Add("INT", 0);
            stats.Add("REF", 0);
            stats.Add("CL", 0);
            stats.Add("TECH", 0);
            stats.Add("LK", 0);
            stats.Add("ATT", 0);
            stats.Add("MA", 0);
            stats.Add("EM", 0);
            stats.Add("BTM", 0);
        }

        double humanityLost = 0;
        public int EM
        {
            
            get
            {
                return stats["EM"] - Convert.ToInt32(Math.Floor(humanityLost)) / 10;
            }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                stats["EM"] = value;
            }
        }
        public double Humanity
        {
            get
            {
                return stats["EM"] * 4 - humanityLost;
            }
            set
            {
                if(value < Humanity)
                {
                    humanityLost += Humanity - value;
                }
            }
        }


    }
}
