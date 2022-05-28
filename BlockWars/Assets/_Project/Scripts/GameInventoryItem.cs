using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameInventoryItem : MonoBehaviour
{
    public GameInventoryItemData itemData;
    public int stackSize;

    public GameInventoryItem(GameInventoryItemData item)
    {
        itemData = item;
        AddToStack();
    }

    public void AddToStack()
    {
        stackSize++;
    }

    public void RemoveFromStack()
    {
        stackSize--;
    }
}
