using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore3Cyberpunk.Backend
{
    class Relationship
    {
        public bool acquaintance;

        bool _enemy;
        public bool Enemy
        {
            set
            {
                acquaintance = true;
				if (Lover)
				{
					Lover = false;
				}
                _enemy = value;
            }
            get
            {
                return _enemy;
            }
        }

        bool _family;
        public bool Family
        {
            set
            {
                acquaintance = true;
                _family = value;
            }
            get
            {
                return _family;
            }
        }

        bool _friend;
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
                    acquaintance = true;
                    Enemy = false;
                }

				if (Lover && value)
				{
					Lover = false;
				}

				_friend = value;
			}
            get
            {
                return _friend;
            }
        }

        public bool exLover;

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
					acquaintance = true;
				}
				else
				{
					exLover = true;
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
