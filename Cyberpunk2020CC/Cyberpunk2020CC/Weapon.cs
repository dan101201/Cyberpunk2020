using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using static Cyberpunk2020CharacterCreator.Utility;

namespace Cyberpunk2020CharacterCreator
{
    
    class Weapon : IItem
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
            VR,
            ST,
            UR
        }

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
        //Weapon Accuracy
        int wa;

        //Concealability, P for Pocket, Pants, Leg or Sleeve. J for Jacket, Coat or Shoulder Rig
        //L for Long Coat, N for Can't be hidden
        Con concealability;

        Avail availability;

        Dice damage;

        int shots;

        //Rate of fire
        int rof;

        Rel reliability;

        

        static Weapon[] XMLToWeapons (string path)
        {

            List<Weapon> weapons = new List<Weapon>();
            XmlDocument doc = new XmlDocument();

            doc.Load(path);
            XmlNodeList nodes = doc.SelectNodes("weapon");

            foreach (XmlNode node in nodes)
            {

                Weapon tempWeapon = new Weapon();

                tempWeapon.name = XmlRemoveAllChildren(node,"name").InnerText;
                tempWeapon.damage = new Dice(XmlRemoveAllChildren(node, "damage").InnerText);
                tempWeapon.shots = int.Parse(XmlRemoveAllChildren(node, "shots").InnerText);
                tempWeapon.rof = int.Parse(XmlRemoveAllChildren(node, "rof").InnerText);
                tempWeapon.cost = double.Parse(XmlRemoveAllChildren(node, "cost").InnerText);
                tempWeapon.wa = int.Parse(XmlRemoveAllChildren(node, "wa").InnerText);
                tempWeapon.concealability = StringToCon(XmlRemoveAllChildren(node, "con").InnerText);
                tempWeapon.reliability = StringToRel(XmlRemoveAllChildren(node, "rel").InnerText);
                tempWeapon.availability = StringToAvail(XmlRemoveAllChildren(node, "avail").InnerText);

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
                    return Rel.UR;
                case "VR":
                    return Rel.VR;
                case "ST":
                    return Rel.ST;
                default:
                    return Rel.UR;
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
