using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Photon.Pun;
using Photon.Realtime;

public class HandleStartGame : MonoBehaviourPunCallbacks
{
    public GameObject myPlayer;
    private int currentId = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("selectedCharacter") != currentId){
            Destroy(GameObject.Find($"LobbyChar{currentId}" + "(Clone)"));
            currentId = PlayerPrefs.GetInt("selectedCharacter");
            LoadNewCharacter();
        }

        
    }

    public void StartGame()
    {
        if(PhotonNetwork.IsConnected){
            PhotonNetwork.JoinRandomOrCreateRoom();
        }else{
            PhotonNetwork.ConnectUsingSettings();
            Debug.Log("Connected to PUN!");
        }
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("Connected to master!");
        PhotonNetwork.JoinRandomOrCreateRoom();
        
        
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        base.OnDisconnected(cause);
        Debug.Log("Disconnected...");
    }

    public override void OnCreatedRoom()
    {
        Destroy(myPlayer);
        base.OnCreatedRoom();
        Debug.Log("Created Room!");
        PhotonNetwork.LoadLevel("PreGameLobby");
    }
    public override void OnJoinedRoom()
    {
        Destroy(myPlayer);
        base.OnJoinedRoom();
        Debug.Log("Joined Room!");
        PhotonNetwork.LoadLevel("PreGameLobby");
    }

    private GameObject LoadNewCharacter()
    {
        GameObject myPlayer = new GameObject();
        myPlayer = (GameObject)Resources.Load($"LobbyCharacters/LobbyChar{PlayerPrefs.GetInt("selectedCharacter")}", typeof(GameObject));
        Instantiate(myPlayer, new Vector3(0,0,0), Quaternion.identity);
        return myPlayer;
    }
}
