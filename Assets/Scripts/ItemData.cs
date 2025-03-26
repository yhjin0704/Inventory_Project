using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItemData", menuName = "Item Data")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string info;
    public Sprite icon;
    public int atk;
    public bool canEquip;
}
