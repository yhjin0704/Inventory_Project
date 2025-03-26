using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;

    private UIManager uiManager;

    private void Start()
    {
        uiManager = UIManager.Instance;

        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        gameObject.SetActive(true);
        uiManager.uiStatus.gameObject.SetActive(false);
        uiManager.uiInventory.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        uiManager.uiStatus.gameObject.SetActive(true);
        uiManager.uiStatus.RefreshUIStatus();
        gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        uiManager.uiInventory.gameObject.SetActive(true);
        uiManager.uiInventory.RefreshInventoryUI();
        gameObject.SetActive(true);
    }

    public void SetCharacterInfo(Character _character)
    {
        nameText.text = _character.playerName;
        levelText.text = $"Lv. {_character.level}";
    }
}

