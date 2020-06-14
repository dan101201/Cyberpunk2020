using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using static Cyberpunk2020Library.Utility;

namespace Cyberpunk2020Library
{

    [Serializable]
    public class Weapon : IItem
    {
        
        enum Con
        {
            P,
            J,
            L,
            N
        }

        enum Avail
        {
            E,
            C,
            P,
            R
        }

        enum Rel
        {
            Vr,
            St,
            Ur
        }

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
        //Weapon Accuracy
        int _wa;

        //Concealability, P for Pocket, Pants, Leg or Sleeve. J for Jacket, Coat or Shoulder Rig
        //L for Long Coat, N for Can't be hidden
        Con _concealability;

        Avail _availability;

        Dice _damage;

        int _shots;

        //Rate of fire
        int _rof;

        Rel _reliability;

        

        static Weapon[] XmlToWeapons (string path)
        {

            List<Weapon> weapons = new List<Weapon>();
            XmlDocument doc = new XmlDocument();

            doc.Load(path);
            XmlNodeList nodes = doc.SelectNodes("weapon");

            foreach (XmlNode node in nodes)
            {

                Weapon tempWeapon = new Weapon
                {
                    _name = XmlRemoveAllChildren(node, "name").InnerText,
                    _damage = new Dice(XmlRemoveAllChildren(node, "damage").InnerText),
                    _shots = int.Parse(XmlRemoveAllChildren(node, "shots").InnerText),
                    _rof = int.Parse(XmlRemoveAllChildren(node, "rof").InnerText),
                    _cost = double.Parse(XmlRemoveAllChildren(node, "cost").InnerText),
                    _wa = int.Parse(XmlRemoveAllChildren(node, "wa").InnerText),
                    _concealability = StringToCon(XmlRemoveAllChildren(node, "con").InnerText),
                    _reliability = StringToRel(XmlRemoveAllChildren(node, "rel").InnerText),
                    _availability = StringToAvail(XmlRemoveAllChildren(node, "avail").InnerText)
                };

            }


            return weapons.ToArray();
        }

        static Con StringToCon(string line)
        {
            switch (line)
            {
                case "P":
                    return Con.P;
                case "J":
                    return Con.J;
                case "L":
                    return Con.L;
                case "N":
                    return Con.N;
                default:
                    return Con.P;
            }
        }

        static Rel StringToRel(string line)
        {
            
            switch (line)
            {
                case "UR":
                    return Rel.Ur;
                case "VR":
                    return Rel.Vr;
                case "ST":
                    return Rel.St;
                default:
                    return Rel.Ur;
            }
        }

        static Avail StringToAvail(string line)
        {

            switch (line)
            {
                case "C":
                    return Avail.C;
                case "E":
                    return Avail.E;
                case "P":
                    return Avail.P;
                case "R":
                    return Avail.R;
                default:
                    return Avail.C;
            }
        }

    }


}
