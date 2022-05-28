using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    public List<GameInventoryItem> inventory = new List<GameInventoryItem>();
    private Dictionary<GameInventoryItemData, GameInventoryItem> itemDictionary = new Dictionary<GameInventoryItemData, GameInventoryItem>();

    public void Add(GameInventoryItemData itemData)
    {
        if(itemDictionary.TryGetValue(itemData, out GameInventoryItem item))
        {
            item.AddToStack();
            Debug.Log($"{item.itemData.displayName} total stack is now {item.stackSize}");
        }
        else{
            GameInventoryItem newItem = new GameInventoryItem(itemData);
            inventory.Add(newItem);
            itemDictionary.Add(itemData, newItem);
            Debug.Log($"Added {itemData.displayName} to the inventory for the 1st time");
        }
    }

    public void Remove (GameInventoryItemData itemData)
    {
        if(itemDictionary.TryGetValue(itemData, out GameInventoryItem item))
        {
            item.RemoveFromStack();
            if(item.stackSize == 0)
            {
                inventory.Remove(item);
                itemDictionary.Remove(itemData);
            }
        }
    }

    private void OnEnable()
    {
        Bandage.OnBandageCollected += Add;
    }

    private void OnDisable()
    {
        Bandage.OnBandageCollected -= Add;
    }
}
