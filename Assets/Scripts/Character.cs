using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string playerName { get; private set; }
    public int level { get; private set; }
    public int hp { get; private set; }
    public int atk { get; private set; }
    [HideInInspector] public int addAtk = 0;
    public int def { get; private set; }
    public List<Item> inventory { get; private set; } = new List<Item>();

    public Character()
    { 
    }

    public Character(string _name, int _level, int _hp, int _atk, int _def)
    {
        playerName = _name;
        level = _level;
        hp = _hp;
        atk = _atk;
        def = _def;
    }

    public void AddItem(Item _item)
    {
        inventory.Add(_item);
    }

    public void EquipItem(Item _item)
    {
        _item.Equip();
        addAtk += _item.atk;
    }

    public void UnEquipItem(Item _item)
    {
        _item.UnEquip();
        addAtk -= _item.atk;
    }

    public int GetTotalAtk()
    { 
        Debug.Log($"รั ฐ๘ฐÝทย: {atk + addAtk}");
        return atk + addAtk;
    }
}
