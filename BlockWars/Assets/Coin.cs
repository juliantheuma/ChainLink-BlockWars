using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IInGameInventoryItem
{
    public string Name 
    {
        get {
            return "Coin";
        }
    }

    public Sprite _Image;
    public Sprite Image
    {
        get { return _Image; }
    }

    public void OnPickUp()
    {
        gameObject.SetActive(false);
    }

    public void OnDrop()
    {
        throw new System.NotImplementedException();
    }
}
