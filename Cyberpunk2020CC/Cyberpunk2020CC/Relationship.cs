﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Relationship
    {
        public Character person;
        public Character character;
        public bool Acquaintance
        {
            set
            {
                Acquaintance = value;
            }
            get
            {
                return Acquaintance;
            }
        }
        public bool Enemy
        {
            set
            {
                Acquaintance = true;
                Enemy = value;
            }
            get
            {
                return Family;
            }
        }

        public bool Family
        {
            set
            {
                Acquaintance = true;
                Family = value;
            }
            get
            {
                return Family;
            }
        }

        public bool Friend
        {
            set
            {
                if (!value)
                {
                    Enemy = false;
                    Friend = value;
                }
                else
                {
                    Acquaintance = true;
                    Enemy = false;
                    Friend = value;
                }
            }
            get
            {
                return Friend;
            }
        }

        public enum quickRelation
        {
            Friend,
            Enemy,
            Acquantance,
            Family
        }
        
        

        
    }
}