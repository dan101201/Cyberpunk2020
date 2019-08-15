using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Character
    {
        public int Eurodollars;
        public int age;
        public Stats stats = new Stats();
        Dictionary<string, int> skills;
        public Role role = new Role();
        public Dictionary<int, string> lifeEvents;
        public Family family;
        public Motivation motivation;
        // -1 enemy, 0 friend, 1 lover, 2 ex-lover, 3 family
        public Dictionary<NPC, int> relationships = new Dictionary<NPC, int>();
    }
}
