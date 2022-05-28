using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;
using Cinemachine;

using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Photon.Realtime;

using MoralisUnity.Platform.Objects;
using MoralisUnity;

public class InGameController : MonoBehaviourPunCallbacks
{
    public int maxLobbySize = 2;
    public CinemachineVirtualCamera myVcam;
    public bool isPaused = false;
    public GameObject pauseCanvas;
    public static InGameController instance;

    public static int killNum = 0;
    public static int playersAlive = 0;
    public TextMeshProUGUI textPlayersAlive;

    public FillStatusBar myHealthBar;
    public GameObject victoryPanel;
    public GameObject loadingPlayersPanel;
    public bool gameStarted = false;
    public MoralisUser user;
    public static int killCount;
    public GameObject gameStartUI; //only visible once game starts.
    public TextMeshProUGUI killCountText;
    public TextMeshProUGUI winCoinCount;
    public TextMeshProUGUI winKillCount;
    public Text endKillCountText;
    public Text endPlayerCountText;

    // public string userAddress;

    // Start is called before the first frame update
    async void Start()
    {
        GameObject myPlayer = PhotonNetwork.Instantiate($"Char{PlayerPrefs.GetInt("selectedCharacter")}", new Vector3(0,2,0), Quaternion.identity);
        Debug.Log("Instantiated player!");
        myVcam.Follow = myPlayer.GetComponent<Transform>();
        myVcam.LookAt = myPlayer.GetComponent<Transform>();
        myHealthBar = GameObject.Find("HealthSlider").GetComponent<FillStatusBar>();
        myHealthBar.playerHealth = myPlayer.GetComponent<Health>();
        //SetPaused();
        playersAlive = PhotonNetwork.CurrentRoom.PlayerCount;
        user = await Moralis.GetUserAsync();
    }

    private void Awake()
    {
        instance = this;
        SetScoreText();
    }

    public void Quit()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        //PhotonNetwork.LeaveLobby();

        //PhotonNetwork.LoadLevel(2);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            SetPaused();
        }

        if(playersAlive == maxLobbySize){
            gameStarted = true;
            DeActivatePanel(loadingPlayersPanel);
            ActivatePanel(gameStartUI);
        }

        if(gameStarted && playersAlive == 1){
            //player left in room has won
            gameStarted = false;
            handleWin();
        }
        killCountText.text = killCount.ToString();
        endKillCountText.text = killCount.ToString();
        endPlayerCountText.text = playersAlive.ToString();
        

        SetScoreText();
    }

    async void SetPaused()
    {
        //set canvas
        pauseCanvas.SetActive(isPaused);
    }

    void SetScoreText()
    {
        textPlayersAlive.text = playersAlive.ToString();
    }

    public static void LoadLobby(){
        SceneManager.LoadScene(0);
        Debug.Log("CHANGED SCENE");
    }

   public override void OnPlayerEnteredRoom(Player other)
   {
       base.OnPlayerEnteredRoom(other);
      if(!gameStarted && playersAlive + 1 <= maxLobbySize){
            playersAlive ++;
            Debug.Log("Players Alive: " + playersAlive);
      }
      else{
           //kick from lobby
      }
   }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        base.OnPlayerLeftRoom(otherPlayer);
        playersAlive--;
    }

    private string getAddress()
    {
        Debug.Log(user.authData["moralisEth"]["id"].ToString());
        return user.authData["moralisEth"]["id"].ToString();
    }

    public async void handleWin()
    {
        Debug.Log("FINAL KILL COUNT: " + killCount);
        ActivatePanel(victoryPanel);
        string address = getAddress();
        winCoinCount.text = (killCount * 100).ToString();
        winKillCount.text = killCount.ToString();

        
        
        var data = new Dictionary<string, object>
        {
            {"address", address},
            {"killAmount", $"{killCount}000000000000000000"},
        };
                var result = await Moralis.GetClient().Cloud.RunAsync<string>("playerWon", data);
                Debug.Log(result);
                //Debug.Log(Moralis.GetClient().ApplicationId);
    }

    private void ActivatePanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    private void DeActivatePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    // public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    // {
    //     if(stream.IsWriting)
    //     {
    //         stream.SendNext(transform.position);
    //     }
    //     else if(stream.IsReading)
    //     {
    //         playersAlive = (int)stream.ReceiveNext();
    //     }
    // }
}
