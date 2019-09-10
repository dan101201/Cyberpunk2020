using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
	class Cybernetic
	{
        public (string stat, int boost) statBoost;
        public Armor sp = null;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        string desc;
        public string Desc
        {
            get
            {
                return desc;
            }
        }
        double cost;
        public double Cost
        {
            get
            {
                return cost;
            }
        }

        public Cybernetic()
        {
        }

        public Cybernetic(string name, string description)
        {
            this.name = name;
            this.desc = description;
        }

        public Cybernetic(string name, string description, string statName, int statboost)
        {
            this.name = name;
            this.desc = description;
            statBoost = (statName, statboost);
        }
    }
}
