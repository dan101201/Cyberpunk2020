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
    class Armor : IItem
    {
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

        public BodyPart bodyPart;

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
                Armor tempArmor = new Armor
                {
                    name = XmlRemoveAllChildren(node, "name").InnerText,
                    desc = XmlRemoveAllChildren(node, "desc").InnerText,
                    sp = int.Parse(XmlRemoveAllChildren(node, "sp").InnerText),
                    ev = int.Parse(XmlRemoveAllChildren(node, "ev").InnerText),
                    cost = double.Parse(XmlRemoveAllChildren(node, "cost").InnerText)
                };

                armors.Add(tempArmor);
            }

            return armors.ToArray();
        }

    }

    

}
