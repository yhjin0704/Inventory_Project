using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI atkText;
    [SerializeField] private TextMeshProUGUI defText;

    [SerializeField] private Button closeButton;

    private Character character;
    private void Start()
    {
        closeButton.onClick.AddListener(CloseStatus);
    }
    public void SetCharacterInfo(Character _character)
    {
        character = _character;
        RefreshUIStatus();
    }
    public void RefreshUIStatus()
    {
        hpText.text = $"{character.hp}";
        atkText.text = $"{character.GetTotalAtk()}";
        defText.text = $"{character.def}";
    }

    public void CloseStatus()
    {
        gameObject.SetActive(false);
        UIManager.Instance.uiMainMenu.OpenMainMenu();
    }
}

