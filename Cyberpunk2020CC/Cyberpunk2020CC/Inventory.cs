using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{

    public class ItemNotRightException : ApplicationException
    {
        public ItemNotRightException(string message)
        {

        }
    }

    class Inventory
    {
        List<object> items = new List<object>();

        public void AddItemToInventory(object item)
        {
            object weapon = new Weapon();
            object armor = new Armor();
            //object cybernetic = new Cybernetic();
            if (item.GetType() == weapon.GetType() || item.GetType() == armor.GetType() /* || item.GetType() == cybernetic.GetType() */ )
            {
                items.Add(item);
            }
            else
            {
                throw new ItemNotRightException("item needs to be of type Weapon, Armor of Cybernetic");
            }
        }

        public object[] GetSortedItems()
        {
            items.Sort();
            return items.ToArray();
        }

        public object[] GetSortedItemsReverse()
        {
            items.Sort();
            items.Reverse();
            return items.ToArray();
        }

        public Type[] GetTypesOfInventory()
        {
            List<Type> types = new List<Type>();

            foreach (object item in items)
            {
                types.Add(item.GetType());
            }

            return types.ToArray();

        }

    }
}
