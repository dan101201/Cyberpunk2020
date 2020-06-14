using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020Library
{
    [Serializable]
    public enum BodyPart
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
    [Serializable]
    public class Body
    {
        public Armor head;
        public Armor torso;
        public Armor rightLeg;
        public Armor leftLeg;
        public Armor rightArm;
        public Armor leftArm;
        public (Armor,Armor) Legs
        {
            get
            {
                return (leftLeg, rightLeg);
            }
            set
            {
                leftLeg = value.Item1;
                rightLeg = value.Item2;
            }
        }
        public (Armor,Armor) Arms
        {
            get
            {
                return (leftArm, rightArm);
            }
            set
            {
                leftArm = value.Item1;
                rightArm = value.Item2;
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
                    head = armor;
                    break;
                case BodyPart.LeftArm:
                    leftArm = armor;
                    break;
                case BodyPart.LeftLeg:
                    leftLeg = armor;
                    break;
                case BodyPart.Legs:
                    Legs = (armor, armor);
                    break;
                case BodyPart.RightArm:
                    rightArm = armor;
                    break;
                case BodyPart.RightLeg:
                    rightLeg = armor;
                    break;
                case BodyPart.Torso:
                    torso = armor;
                    break;
            }
        }
    }
}
