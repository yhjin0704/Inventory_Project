using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI infoText;
    [SerializeField] private TextMeshProUGUI equipStateText;

    private Item item;

    public void SetItem(Item _newItem)
    {
        item = _newItem;
        RefreshSlot();

        GetComponent<Button>().onClick.AddListener(OnClickSlot);
    }
    private void OnClickSlot()
    {
        item.ToggleEquip();

        RefreshSlot();

        UIManager.Instance.uiStatus.RefreshUIStatus();
    }

    public void RefreshSlot()
    {
        if (item == null)
        {
            Debug.LogWarning("item이 null입니다.");
            return;
        }

        if (nameText == null)
        {
            Debug.LogError("nameText가 null입니다!");
        }

        if (infoText == null)
        {
            Debug.LogError("descriptionText가 null입니다!");
        }

        if (iconImage == null)
        {
            Debug.LogError("iconImage가 null입니다!");
        }

        iconImage.sprite = item.icon;
        nameText.text = item.itemName;
        infoText.text = item.info;

        if (item.canEquip)
        {
            equipStateText.text = item.isEquip ? "E" : "";
            equipStateText.color = Color.red;
        }
        else
        {
            equipStateText.text = "";
        }

    }
}
