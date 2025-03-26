using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using static UnityEditor.Progress;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button returnButton;

    [SerializeField] private Transform slotParent;
    [SerializeField] private GameObject slotPrefab; 

    private void Start()
    {
        returnButton.onClick.AddListener(CloseInventory);
    }

    private List<UISlot> slotList = new List<UISlot>();

    public void InitInventoryUI(List<Item> _items)
    {
        foreach (Transform child in slotParent)
        {
            Destroy(child.gameObject);
        }

        slotList.Clear();
    }

    public void RefreshInventoryUI()
    {
        foreach (UISlot slot in slotList)
        {
            slot.RefreshSlot();
        }
    }
    public void AddItemToInventory(Item _item)
    {
        GameObject slotObj = Instantiate(slotPrefab, slotParent);
        UISlot slot = slotObj.GetComponent<UISlot>();
        slot.SetItem(_item);
        slotList.Add(slot);
    }
    public void AddItemToInventory(ItemData _itemData)
    {
        Item item = ItemManager.Instance.CreateItem(_itemData);

        GameObject slotObj = Instantiate(slotPrefab, slotParent);
        UISlot slot = slotObj.GetComponent<UISlot>();
        slot.SetItem(item);
        slotList.Add(slot);
    }

    public void CloseInventory()
    {
        gameObject.SetActive(false);
        UIManager.Instance.uiMainMenu.OpenMainMenu();
    }
}
