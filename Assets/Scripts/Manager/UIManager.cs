using UnityEngine;
public class UIManager : MonoBehaviour
{
   public static UIManager Instance { get; private set; }

    public UIMainMenu uiMainMenu;
    public UIStatus uiStatus;
    public UIInventory uiInventory; 

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
}

