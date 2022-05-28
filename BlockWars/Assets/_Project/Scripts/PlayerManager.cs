using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int myCoins = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        //Coin.OnCoinCollected += IncrementCoinCount;
    }

    private void IncrementCoinCount()
    {
        myCoins++;
        Debug.Log("My Coins: " + myCoins);
    }

    private void OnDisable()
    {
        //Coin.OnCoinCollected -= IncrementCoinCount;
    }
}
