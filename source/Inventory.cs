using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cyberpunk2020Library
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

    public class ItemNotEquipedException : ApplicationException
    {
        public ItemNotEquipedException()
        {

        }
    }

    [Serializable]
    public class Inventory
    {
        List<(object item, bool equiped, Type)> items = new List<(object, bool, Type)>();
        (IItem, bool, Type)[] sortedItems;

        public void EquipItem(object item, Character c)
        {
            EquipItem(ObjectToInventoryTuple(item),c);
        }

        public void EquipItem((object item, bool equiped) item, Character c)
        {
            if (!item.equiped)
            {
                item.equiped = true;

            }
            throw new ItemAlreadyEquipedException();
        }

        void EquipCybernetic(Cybernetic cyber, Character c)
        {
            c.stats[c.stats.ToIndex(cyber.statBoost.stat)] = c.stats[c.stats.ToIndex(cyber.statBoost.stat)] + cyber.statBoost.boost;
        }

        void EquipArmor(Armor armor, Character c)
        {
            c.body.EquipArmor(armor);
        }

        public void UnEquipItem(object item, Character c)
        {
            UnEquipItem(ObjectToInventoryTuple(item), c);
        }

        public void UnEquipItem((object item, bool equiped) item, Character c)
        {
            if (item.equiped)
            {
                item.equiped = false;

            }
            throw new ItemNotEquipedException();
        }

        void UnEquipCybernetic(Cybernetic cyber, Character c)
        {
            c.stats[c.stats.ToIndex(cyber.statBoost.stat)] = c.stats[c.stats.ToIndex(cyber.statBoost.stat)] + cyber.statBoost.boost;
        }

        void UnEquipArmor(Armor armor, Character c)
        {
            c.body.EquipArmor(new Armor());
        }

        public void AddItemToInventory(Weapon weapon)
        {
            items.Add((weapon,false,typeof(Weapon)));
        }

        public void AddItemToInventory(Armor armor)
        {
            items.Add((armor, false, typeof(Armor)));
        }

        public void AddItemToInventory(Cybernetic cybernetic)
        {
            items.Add((cybernetic, false, typeof(Cybernetic)));
            Thread t = new Thread(SetItemArray);
            t.Start();
        }

        public void AddItemToInventory(IItem item)
        {
            items.Add((item, false, typeof(IItem)));
            Thread t = new Thread(SetItemArray);
            t.Start();
        }

        public void RemoveItemFromInventory(object item)
        {
            foreach ((object item, bool equiped, Type) tuple in items)
            {
                if (item == tuple.item)
                {
                    items.Remove(tuple);
                }
            }
        }

        public (IItem, bool,Type)[] GetItemArray()
        {
            return sortedItems;
        }

        void SetItemArray()
        {
            ClassComparer comparer = new ClassComparer();
            List<IItem> items = new List<IItem>();
            foreach ((object, bool,Type) item in this.items)
            {
                items.Add((IItem)item.Item1);
            }
            IItem[] itemArr = comparer.SortIItems(items.ToArray());
            List<(IItem, bool,Type)> valueTuppleArr = new List<(IItem, bool,Type)>();
            for (int i = 0; i < itemArr.Length; i++)
            {
                valueTuppleArr.Add((itemArr[i], this.items[i].equiped,this.items[i].Item3));
            }
            sortedItems = valueTuppleArr.ToArray();
        }

        (object, bool,Type) ObjectToInventoryTuple(object item)
        {
            foreach ((object item, bool equiped, Type) _item in items)
            {
                if (_item.item == item)
                {
                    return _item;
                }
            }
            throw new ItemDoesNotExistException("Object could not be found in list of valuetuples");
        }

    }
}
