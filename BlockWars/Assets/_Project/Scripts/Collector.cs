using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Colliding");
        ICollectible collectible = collision.GetComponent<ICollectible>();
        if(collectible != null){
            collectible.Collect();
        }
    }
}
