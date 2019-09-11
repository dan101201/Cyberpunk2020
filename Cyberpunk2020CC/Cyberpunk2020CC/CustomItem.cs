using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class CustomItem : IItem
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        string desc;
        public string Desc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }
        double cost;
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
    }
}
