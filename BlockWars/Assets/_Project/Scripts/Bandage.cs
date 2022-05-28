using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandage : MonoBehaviour, ICollectible
{
    public static event HandleBandageCollected OnBandageCollected;
    public delegate void HandleBandageCollected(GameInventoryItemData itemData);
    public GameInventoryItemData bandageData;

    public void Collect()
    {
        Destroy(gameObject);
        OnBandageCollected?.Invoke(bandageData);
    }
}
