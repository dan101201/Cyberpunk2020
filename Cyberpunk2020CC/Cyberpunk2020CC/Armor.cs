using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyberpunk2020CharacterCreator.Utility;
using System.Xml;

namespace Cyberpunk2020CharacterCreator
{
    //Gear
    class Armor
    {
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

        //Stopping Power
        public int sp = 0;

        //Encumberance
        public int ev = 0;

        static Armor[] XmlDocToArmorArray(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            List<Armor> armors = new List<Armor>();

            XmlNodeList list = doc.SelectNodes("role");
            foreach (XmlNode node in list)
            {
                Armor tempArmor = new Armor();

                tempArmor.name = XmlRemoveAllChildren(node, "name").InnerText;
                tempArmor.desc = XmlRemoveAllChildren(node, "desc").InnerText;
                tempArmor.sp = int.Parse(XmlRemoveAllChildren(node, "sp").InnerText);
                tempArmor.ev = int.Parse(XmlRemoveAllChildren(node, "ev").InnerText);
                tempArmor.cost = double.Parse(XmlRemoveAllChildren(node, "cost").InnerText);
                tempArmor.weight = double.Parse(XmlRemoveAllChildren(node, "weight").InnerText);

                armors.Add(tempArmor);
            }

            return armors.ToArray();
        }

    }

    

}
