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

        static List<Cybernetic> _cybernetics = new List<Cybernetic>();

        public (string stat, int boost) statBoost;
        public Armor sp = null;
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }
        string _desc;
        public string Desc
        {
            get
            {
                return _desc;
            }
        }
        double _cost;
        public double Cost
        {
            get
            {
                return _cost;
            }
        }

        public Cybernetic()
        {
        }

        public Cybernetic(string name, string description)
        {
            this._name = name;
            this._desc = description;
        }

        public Cybernetic(string name, string description, string statName, int statboost)
        {
            this._name = name;
            this._desc = description;
            statBoost = (statName, statboost);
        }
    }
}
