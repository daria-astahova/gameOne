// GameManager.cs
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InventoryManager inventoryManager;

    void Start()
    {
        inventoryManager = InventoryManager.instance;
    }

    // Called when a player hits an obstacle
    public void PlayerHitObstacle()
    {
        // Implement scoring logic here
    }

    // Called when a player collects an item
    public void PlayerCollectedItem()
    {
        inventoryManager.AddItem("CollectibleItem");
        // Implement scoring logic here
    }
}
