using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteScript : MonoBehaviour
{

    public Animator animator;




    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doAnimation1(){
        Debug.Log("Woo");
        animator.SetInteger("animIndex", 1);
        animator.SetBool("isEmoting", true);
    }

    public void doAnimation2(){
        Debug.Log("Boo");
        animator.SetInteger("animIndex", 2);
        animator.SetBool("isEmoting", true);
    }

    public void doAnimation3(){
        Debug.Log("Joo");
        animator.SetInteger("animIndex", 3);
        animator.SetBool("isEmoting", true);

    }

    public void doAnimation4(){
        Debug.Log("Koo");
        animator.SetInteger("animIndex", 4);
        animator.SetBool("isEmoting", true);

    }

    public void doAnimation5(){
        Debug.Log("Zoo");
        animator.SetInteger("animIndex", 5);
        animator.SetBool("isEmoting", true);

    }

}
