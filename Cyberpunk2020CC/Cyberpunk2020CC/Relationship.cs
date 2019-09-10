using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Relationship
    {
        public bool Acquaintance;

        bool enemy;
        public bool Enemy
        {
            set
            {
                Acquaintance = true;
				if (Lover)
				{
					Lover = false;
				}
                enemy = value;
            }
            get
            {
                return enemy;
            }
        }

        bool family;
        public bool Family
        {
            set
            {
                Acquaintance = true;
                family = value;
            }
            get
            {
                return family;
            }
        }

        bool friend;
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

				friend = value;
			}
            get
            {
                return friend;
            }
        }

        public bool ExLover;

        public bool lover;
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
				lover = value;
			}
			get
			{
				return lover;
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
