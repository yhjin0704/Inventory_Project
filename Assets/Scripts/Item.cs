using UnityEngine;

public class Item
{
    public string itemName { get; private set; }
    public string info { get; private set; }
    public Sprite icon { get; private set; }
    public int atk { get; private set; }
    public bool isEquip { get; private set; }
    public bool canEquip { get; private set; }

    public Item(string _name, string _info, Sprite _icon, int _atk, bool _canEquip)
    {
        itemName = _name;
        info = _info;
        icon = _icon;
        atk = _atk;
        canEquip = _canEquip;
        isEquip = false;
    }

    public void Equip()
    {
        isEquip = true;
    }

    public void UnEquip()
    {
        isEquip = false;
    }

    public void ToggleEquip()
    {
        if (!canEquip)
        {
            return;
        }

        isEquip = !isEquip;

        if (isEquip)
        {
            GameManager.Instance.player.EquipItem(this);
        }
        else
        {
            GameManager.Instance.player.UnEquipItem(this);
        }
    }
}
