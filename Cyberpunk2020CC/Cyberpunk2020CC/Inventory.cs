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

    public class ItemDoesNotExistException : ApplicationException
    {
        public ItemDoesNotExistException(string message)
        {

        }
    }

    public class ItemAlreadyEquipedException : ApplicationException
    {
        public ItemAlreadyEquipedException()
        {

        }
    }

    class Inventory
    {
        List<(object item, bool equiped)> items = new List<(object, bool)>();

        public void EquipItem(object item)
        {
            EquipItem(ObjectToInventoryTuple(item));
        }

        public void EquipItem((object item, bool equiped) item)
        {
            if (item.equiped)
            {
                throw new ItemAlreadyEquipedException();
            }
        }

        public void AddItemToInventory(object item)
        {
            AddItemToInventory(item,false);
        }

        public void AddItemToInventory(object item, bool equip)
        {
            object weapon = new Weapon();
            object armor = new Armor();
            object cybernetic = new Cybernetic();
            //object cybernetic = new Cybernetic();
            if (item.GetType() == weapon.GetType() || item.GetType() == armor.GetType() || item.GetType() == cybernetic.GetType())
            {
                items.Add((item, equip));
            }
            else
            {
                throw new ItemNotRightException("Object needs to be of type Weapon, Armor or Cybernetic but has type " + item.GetType().ToString());
            }
        }

        public (object, bool)[] GetItems()
        {
            var temp = items;
            items.Sort();
            var sortedList = items;
            items = temp;
            return sortedList.ToArray();
        }

        (object, bool) ObjectToInventoryTuple(object item)
        {
            foreach (var _item in items)
            {
                if (_item.Item1 == item)
                {
                    return _item;
                }
            }
            throw new ItemDoesNotExistException("Object could not be found in list of valuetuples");
        }

    }
}
