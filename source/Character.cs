using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020Library
{
    [Serializable]
    public class Character
    {

        //All life events
        public Dictionary<int, string> lifeEvents;

        public int points = 0;

        public int hp;

        //Age
        public int age;

        //Money
        public int Eurodollars;

        //Name for the Character
        public string name;

        //If false, its female
        public bool male;

        //The class/role of the Character
        public Role role = new Role();

        //Dictionary full of the skills
        Skills skills = new Skills();

        //Stats for the Character
        public Stats stats = new Stats();

        //Inventory, it says in the name of the class.
        public Inventory inv = new Inventory();

        public Body body = new Body();

        //The Character's Style
        public Style style = new Style();
        public Motivation motivation;
        public Dictionary<Character,Relationship> relationships = new Dictionary<Character, Relationship>();
        public bool NPC;

        /// <summary>
        /// Generates random Character using all of the other functions in this class
        /// </summary>
        public Character()
        {
        }

        public Character(string name, bool npc)
        {
            this.name = name;
            this.NPC = npc;
        }

        public void EquipItem(object item)
        {
            inv.EquipItem(item,this);
        }

        public void UnEquipItem(object item)
        {
            inv.UnEquipItem(item, this);
        }

        public void EquipItem(Weapon t)
        {
            inv.AddItemToInventory(t);
        }
        public void EquipItem(Cybernetic t)
        {
            inv.AddItemToInventory(t);
        }
        public void EquipItem(Armor t)
        {
            inv.AddItemToInventory(t);
        }
        public void EquipItem(IItem t)
        {
            inv.AddItemToInventory(t);
        }

        public void RemoveItemFromInventory(object item)
        {
            inv.RemoveItemFromInventory(item);
        }

        /// <summary>
        /// Generates random Character using all of the other functions in this class
        /// </summary>
        /// <returns>Character</returns>
        public static Character GenerateRandomNPC(int points)
        {
            Character res = new Character();
            res.points = points;
            Random rnd = new Random();
            res.male = rnd.Next(0,2) != 0;
            res.name = RandomNameGenerator(res.male);
            res.role = Role.roles[Role.IntToRoleName(rnd.Next(0,11))];
            res.style.RandomlySelectStyle();
            res.motivation = Motivation.RandomlyGenerateMotivation();
            rnd.Next(1, 10);
            //temp.role = Role.roles[Role.IntToRoleName(rnd.Next(1, 10)).ToLower()];
            //temp.stats = Stats.GenerateStatsForNpc(points, temp);
            res.NPC = true;

            res.age = 16 + rnd.Next(1, 6) + rnd.Next(1, 6);
            return res;
        }

        public static Character GenerateRandomNPC()
        {
            var rnd = new Random();
            int points = rnd.Next(30, 65);
            return GenerateRandomNPC(points);
        }

        /// <summary>
        /// Randomly generates a name based on if the name needed is male or not
        /// </summary>
        /// <returns>string</returns>
        public static string RandomNameGenerator (bool male)
        {
            Random rnd = new Random();
            int firstNameId = rnd.Next(0, 1000);
            int surnameId = rnd.Next(0, 972);
            string[] firstNames;
            string[] surnames = Properties.Resources.Surnames.Split('\n');
            if (male)
            {
                firstNames = Properties.Resources.MaleNames.Split('\n');
            }
            else
            {
                firstNames = Properties.Resources.FemaleNames.Split('\n');
            }
            var res = (firstNames[firstNameId] + surnames[surnameId]).Replace('\r',' ');
            return res.Trim();
        }

        /// <summary>
        /// Randomly generates a gender and parses to overload function.
        /// </summary>
        /// <returns>string</returns>
        public static string RandomNameGenerator()
        {
            Random rnd = new Random();
            bool male = rnd.Next(0, 1) != 0;
            return RandomNameGenerator(male);
        }

        public static Character MakeQuickRelation(Character npc, Relationship.QuickRelation relation)
        {
            Character temp = GenerateRandomNPC();
            Relationship rel = new Relationship();
            
            switch (relation)
            {
                case Relationship.QuickRelation.Enemy:
                    rel.Enemy = true;
                    break;

                case Relationship.QuickRelation.Family:
                    rel.Family = true;
                    break;

                case Relationship.QuickRelation.Friend:
                    rel.Friend = true;
                    break;

                case Relationship.QuickRelation.Acquantance:
                    rel.acquaintance = true;
                    break;
            }

            temp.relationships.Add(npc,rel);
            npc.relationships.Add(temp,rel);
            return temp;
        }

    }
}
