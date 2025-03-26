using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private ItemManager itemManager;
    private UIManager uiManager;

    public Character player { get; private set; }

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

    private void Start()
    {
        itemManager = ItemManager.Instance;
        uiManager = UIManager.Instance;

        SetData();
    }

    public void SetData()
    {
        player = new Character("Player", 1, 100, 10, 10);

        Item dagger = itemManager.CreateItem(itemManager.daggerData);
        Item potion = itemManager.CreateItem(itemManager.potionData);

        player.AddItem(dagger);
        player.AddItem(potion);

        uiManager.uiMainMenu.SetCharacterInfo(player);
        uiManager.uiStatus.SetCharacterInfo(player);
        uiManager.uiInventory.InitInventoryUI(player.inventory);

        uiManager.uiMainMenu.OpenMainMenu();
    }
}

