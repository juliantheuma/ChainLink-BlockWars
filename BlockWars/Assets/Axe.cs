using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour, IInGameInventoryItem
{
   public string Name
   {
       get
       {
           return "Axe";
       }
   }

   public Sprite _Image = null;

   public Sprite Image
   {
       get
       {
           return _Image;
       }
   }

    public void OnPickUp()
    {
        gameObject.SetActive(false);
    }

    public void OnDrop()
    {
        //raycast position to screen and set object's position to point of contact
        Debug.Log("AXEDROP");
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 1000))
        {
            gameObject.SetActive(true);
            Debug.Log("Instantiated object at: " + hit.point);
            gameObject.transform.position = hit.point;
        }
    }
}
