using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{

    enum BodyPart
    {
        Head,
        Torso,
        Legs,
        Arms,
        RightArm,
        LeftArm,
        RightLeg,
        LeftLeg
    }

    class Body
    {
        public Armor Head;
        public Armor Torso;
        public Armor RightLeg;
        public Armor LeftLeg;
        public Armor RightArm;
        public Armor LeftArm;
        public (Armor,Armor) Legs
        {
            get
            {
                return (LeftLeg, RightLeg);
            }
            set
            {
                LeftLeg = value.Item1;
                RightLeg = value.Item2;
            }
        }
        public (Armor,Armor) Arms
        {
            get
            {
                return (LeftArm, RightArm);
            }
            set
            {
                LeftArm = value.Item1;
                RightArm = value.Item2;
            }
        }

        public void EquipArmor(Armor armor)
        {
            switch(armor.bodyPart)
            {
                case BodyPart.Arms:
                    Arms = (armor, armor);
                    break;
                case BodyPart.Head:
                    Head = armor;
                    break;
                case BodyPart.LeftArm:
                    LeftArm = armor;
                    break;
                case BodyPart.LeftLeg:
                    LeftLeg = armor;
                    break;
                case BodyPart.Legs:
                    Legs = (armor, armor);
                    break;
                case BodyPart.RightArm:
                    RightArm = armor;
                    break;
                case BodyPart.RightLeg:
                    RightLeg = armor;
                    break;
                case BodyPart.Torso:
                    Torso = armor;
                    break;
            }
        }
    }
}
