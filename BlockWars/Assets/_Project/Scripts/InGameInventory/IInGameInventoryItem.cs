using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInGameInventoryItem
{
    string Name { get; }
    Sprite Image { get ; }
    void OnPickUp();
    void OnDrop();
}

public class InventoryEventArgs: EventArgs
{
    public IInGameInventoryItem Item;
    public InventoryEventArgs(IInGameInventoryItem item)
    {
        Item = item;
    }
}
