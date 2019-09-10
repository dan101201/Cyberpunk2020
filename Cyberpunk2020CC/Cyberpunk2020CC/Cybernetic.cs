using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
	class Cybernetic
	{
        public Dictionary<string, int> _statBoosts
        {
            private set;
            get;
        }
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        double weight;
        public double Weight
        {
            get
            {
                return weight;
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
            _statBoosts.Add(statName, statboost);
        }
    }
}
