using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    public Animator animator;
    void start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations() {
        if (Input.GetAxis("Horizontal") != 0)
        {
           
            animator.SetTrigger("RunTrigger");
           
        }
        else {
            
            animator.SetTrigger("IdolTrigger");
        }

        if (Input.GetButtonDown("Jump")) { 
            animator.SetTrigger("JumpTrigger");
           
        }
       
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJumptrigger");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("FallTrigger");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("HitTrigger");
        }
    }
}
