using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using System;

public class Health : MonoBehaviourPunCallbacks, IPunObservable
{
    public int health = 200;
    public float maxHealth = 200f;
    Renderer [] visuals;
    public bool isAlive = true;
    [SerializeField] private GameObject gameOverUi;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(stream.IsWriting)
        {
            stream.SendNext(health);
        }
        else
        {
            health = Convert.ToInt32(stream.ReceiveNext());
        }
    }

    public float TakeDamage(int damage)
    {
        health -= damage;
        
        return health;
    }

    IEnumerator Respawn()
    {
        SetRenderers(false);
        health = 200;
        GetComponent<CharacterController>().enabled = false;
        transform.position = new Vector3(0,10,0);
        yield return new WaitForSeconds(3);
        GetComponent<CharacterController>().enabled = true;
        SetRenderers(true);
    }

    void SetRenderers(bool state)
    {
        foreach(var renderer in visuals)
        {
            renderer.enabled = state;
        }
    }

    // Start is called before the first frame update

    
    void Start()
    {
        visuals = GetComponentsInChildren<Renderer>();
        Debug.Log("GameOverUI Found!");
        gameOverUi = GameObject.Find("GameOverUI");
    }

    // Update is called once per frame
    void Update()
    {
        if(health < 0 && photonView.IsMine){
            RPC_PlayerKilled();
        }
    }

    //[PunRPC]
    void RPC_PlayerKilled()
    {
        if(photonView.IsMine){
        StartCoroutine(DisconnectAndLoadHome());

        //InGameController.playersAlive --;
        gameOverUi.SetActive(true);
        GameObject txt = gameOverUi.transform.GetChild(0).gameObject;
        txt.SetActive(true);
        }
        
        
    }

    IEnumerator DisconnectAndLoadHome(){
        
        
        PhotonNetwork.LeaveRoom();
        while (PhotonNetwork.InRoom)
            yield return null;
        
    }

    public void LoadLobby(){

    }

}
