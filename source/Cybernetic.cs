using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020Library
{
    [Serializable]
    public class Cybernetic
	{
        public (string stat, int boost) statBoost;
        //public Armor sp = null;
        public string name = "";
        public int hl = 0;
        public string desc = "";
        public double cost = 0;
    }
}
