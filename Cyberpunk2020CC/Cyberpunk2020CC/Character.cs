using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class Character
    {
        //Money
        public int Eurodollars;

        //Age
        public int age;

        //The stats for the character
        public Stats stats = new Stats();

        //Dictionary full of the skills
        Dictionary<string, int> skills;

        //class/role
        public Role role = new Role();

        //All life events
        public Dictionary<int, string> lifeEvents;

        //Motivation for the character
        public Motivation motivation;

        // -1 enemy, 0 friend, 1 lover, 2 ex-lover, 3 family
        //Maybe move family or make relationships its own class using an enum
        public Dictionary<NPC, int> relationships = new Dictionary<NPC, int>();
    }
}
