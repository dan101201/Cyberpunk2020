using System;
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
        public bool Acquaintance { get; set; }

        public bool Enemy
        {
            set
            {
                Acquaintance = true;
				if (Lover)
				{
					Lover = false;
				}
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
                }
                else
                {
                    Acquaintance = true;
                    Enemy = false;
                }

				if (Lover && value)
				{
					Lover = false;
				}

				Friend = value;
			}
            get
            {
                return Friend;
            }
        }

		public bool ExLover { get; set; }

		public bool Lover
		{
			set
			{
				if (value)
				{
					if (Friend)
					{
						Friend = false;
					}
					Acquaintance = true;
				}
				else
				{
					ExLover = true;
				}
				Lover = value;
			}
			get
			{
				return Lover;
			}
		}

        public enum QuickRelation
        {
            Friend,
            Enemy,
            Acquantance,
            Family,
			ExLover,
			Lover
        }
        
        

        
    }
}
