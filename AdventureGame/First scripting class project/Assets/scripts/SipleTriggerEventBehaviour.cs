using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SipleTriggerEventBehaviour : MonoBehaviour
{
   public Animator animator;
    
    public UnityEvent triggerEvent;

    void start() {
      //  animator = GetComponent<Animator>();
    }
   
    private void OnTriggerEnter(Collider other) 
    {
        triggerEvent.Invoke();
        animator.SetTrigger("HitTrigger");
        Debug.Log("player touched the spike!");
    }
}
