using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance { get; private set; }

    public ItemData daggerData;
    public ItemData potionData;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Item CreateItem(ItemData _itemData)
    {
        Item newItem = new Item(_itemData.itemName, _itemData.info, _itemData.icon, _itemData.atk, _itemData.canEquip);
        return newItem;
    }
}
