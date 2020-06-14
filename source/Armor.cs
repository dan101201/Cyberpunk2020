using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyberpunk2020Library.Utility;
using System.Xml;

namespace Cyberpunk2020Library
{
    //Gear
    [Serializable]
    class Armor : IItem
    {
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
                    _name = XmlRemoveAllChildren(node, "name").InnerText,
                    _desc = XmlRemoveAllChildren(node, "desc").InnerText,
                    sp = int.Parse(XmlRemoveAllChildren(node, "sp").InnerText),
                    ev = int.Parse(XmlRemoveAllChildren(node, "ev").InnerText),
                    _cost = double.Parse(XmlRemoveAllChildren(node, "cost").InnerText)
                };

                armors.Add(tempArmor);
            }

            return armors.ToArray();
        }

    }

    

}
