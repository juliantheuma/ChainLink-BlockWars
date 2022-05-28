using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Gun : MonoBehaviourPunCallbacks
{
    public int damage = 10;
    public float range = 100f;
    public GameObject gunTip;
     private PlayerControls playerControls;
     private PlayerInput playerInput;
     public GameObject textKillNumObject;
     public TextMeshProUGUI textKillNum;
     public int kills = 0;
     public float fireRate = 10f;
     private float nextTimeToFire = 0f;
     public Dictionary<int, bool> playersKilled = new Dictionary<int, bool>();
     public ParticleSystem muzzleFlash;
     public GameObject muzzle;

private void Awake()
    {
        playerControls = new PlayerControls();
        playerInput = GetComponent<PlayerInput>();
        muzzle = GameObject.Find("C_Bullet");
    }

    void Start()
    {
     //   textKillNumObject = GameObject.Find("KillNum");
//        textKillNum = textKillNumObject.GetComponent<TextMeshProUGUI>();
    }
    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Update()
    {
        if(photonView.IsMine){

        //if (playerControls.Controls.Shoot.IsPressed() && Time.time >= nextTimeToFire)
        
        if (playerControls.Controls.Shoot.IsPressed())
        {
            //Shoot();
            //nextTimeToFire = Time.time + 1f/fireRate;
            photonView.RPC("RPC_Shoot", RpcTarget.All);
            photonView.RPC("RPC_MuzzleFlash", RpcTarget.Others, muzzleFlash.transform.position, muzzleFlash.transform.rotation);
            muzzleFlash.Play();
        }
        }

    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(gunTip.transform.position, gunTip.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }

    [PunRPC]
    void RPC_Shoot()
    {
        //PhotonNetwork.Instantiate("Particle System", muzzle.transform.position, muzzle.transform.rotation);
        RaycastHit hit;
        if(Physics.Raycast(gunTip.transform.position, gunTip.transform.forward, out hit, range))
        {
            
            // Target target = hit.transform.GetComponent<Target>();
            // if(target != null)
            // {
            //     target.TakeDamage(damage);
            // }

            Health targetHealth = hit.transform.GetComponent<Health>();
            if(targetHealth)
            {
                float enemyHealth = targetHealth.TakeDamage(damage);
                if(enemyHealth <= 0){
                    //YOU KILLED OPPONENT
                    //InGameController.playersAlive --;
                    kills++;
                    SetScoreText();
                        Debug.Log("Target instance id: " + targetHealth.GetInstanceID());

                    if(playersKilled.ContainsKey(targetHealth.GetInstanceID())){
                        Debug.Log("KEY CONTAINED");
                    }else{
                        Debug.Log("NEW KEY");
                        playersKilled.Add(targetHealth.GetInstanceID(), true);
                        InGameController.killCount++;
                        Debug.Log("KILL COUNTER: " + InGameController.killCount);
                    }
                }
                Debug.Log("Enemy health: " + targetHealth.health);
            }
        }
    }
    [PunRPC]
    void RPC_MuzzleFlash(Vector3 position, Quaternion rotation)
    {
        PhotonNetwork.Instantiate("Particle System", position, rotation);
    }

    void SetScoreText()
    {
        //textKillNum.text = kills.ToString();
    }
}
