using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        gameObject.SetActive(true);
        UIManager.Instance.uiStatus.gameObject.SetActive(false);
        UIManager.Instance.uiInventory.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        UIManager.Instance.uiStatus.gameObject.SetActive(true);
        UIManager.Instance.uiStatus.RefreshUIStatus();
        gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.Instance.uiInventory.gameObject.SetActive(true);
        gameObject.SetActive(true);
    }

    public void SetCharacterInfo(Character _character)
    {
        nameText.text = _character.playerName;
        levelText.text = $"Lv. {_character.level}";
    }
}

