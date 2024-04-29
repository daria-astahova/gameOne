using UnityEngine;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour, IGameManager
{
    public static InventoryManager instance { get; private set; } // Singleton instance
    public ManagerStatus status { get; private set; }
    private List<string> _items;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; // Set the singleton instance
            DontDestroyOnLoad(gameObject); // Ensure the GameManager persists between scenes
        }
        else
        {
            Destroy(gameObject); // If an instance already exists, destroy this duplicate
        }
    }

    public void Startup()
    {
        Debug.Log("Inventory manager starting...");
        _items = new List<string>();
        status = ManagerStatus.Started;
    }

    private void DisplayItems()
    {
        string itemDisplay = "Items: ";
        foreach (string item in _items)
        {
            itemDisplay += item + " ";
        }
        Debug.Log(itemDisplay);
    }

    public void AddItem(string name)
    {
        _items.Add(name);
        DisplayItems();
    }
}
