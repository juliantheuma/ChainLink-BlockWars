using System.Collections;
using System.Collections.Generic;
using MoralisUnity;
using UnityEngine;

public class PlayerItem : InventoryItem
{
    public void OnItemClicked()
    {
        //MoralisTools.CheckNftOnOpenSea(GameManager.ContractAddress, GameManager.ContractChain.ToString(), GetId());
        Debug.Log(GetId());
        GameObject.Find("PlayerInventory").transform.GetChild(0).gameObject.SetActive(false);
        PlayerPrefs.SetInt("selectedCharacter", int.Parse(GetId()));
    }
}
