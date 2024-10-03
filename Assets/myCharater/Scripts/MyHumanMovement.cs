using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHumanMovement : MonoBehaviour
{
    Animator anim;
    CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();

        anim.SetBool("isDef", false);
        anim.SetBool("isWalking", false);
        anim.SetBool("isDancing", false);
        //Time to start the animation
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isDef", true);
             anim.SetBool("isDancing", false);
        }
    
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isDancing", true);
            anim.SetBool("isWalking", true);
            anim.SetBool("isDef", false);
        }
        
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isDef", true);
            anim.SetBool("isDancing", true);
            anim.SetBool("isWalking", false);
        }
        // Your movement and animation logic here
       // anim.SetBool("isWalking", true);
    }
}