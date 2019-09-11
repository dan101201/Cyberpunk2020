﻿using System;
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

    public class ItemNotEquipedException : ApplicationException
    {
        public ItemNotEquipedException()
        {

        }
    }

    class Inventory
    {
        List<(object item, bool equiped)> items = new List<(object, bool)>();

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

        public void RemoveItemFromInventory(object item)
        {
            foreach ((object item, bool equiped) tuple in items)
            {
                if (item == tuple.item)
                {
                    items.Remove(tuple);
                }
            }
        }

        public (object, bool)[] GetItemArray()
        {
            var temp = items;
            items.Sort();
            var sortedList = items;
            items = temp;
            return sortedList.ToArray();
        }

        (object, bool) ObjectToInventoryTuple(object item)
        {
            foreach ((object item, bool equiped) _item in items)
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
