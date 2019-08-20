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
        //Name of armor
        public string name;

        //Stopping Power
        public int sp = 0;

        //Encumberance
        public int ev = 0;

        public double cost = 0;

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
                tempArmor.sp = int.Parse(XmlRemoveAllChildren(node, "sp").InnerText);
                tempArmor.ev = int.Parse(XmlRemoveAllChildren(node, "ev").InnerText);
                tempArmor.cost = double.Parse(XmlRemoveAllChildren(node, "cost").InnerText);

                armors.Add(tempArmor);
            }

            return armors.ToArray();
        }

    }

    

}
