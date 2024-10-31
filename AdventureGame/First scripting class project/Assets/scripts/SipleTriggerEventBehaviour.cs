using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class SipleTriggerEventBehaviour : MonoBehaviour
{
   public Animator animator;
    public Slider helthbar;
    public float Player_health;
    public Slider NRGbar;
    public float Player_NRG;
    public UnityEvent triggerEvent;

    void start() {
        //  animator = GetComponent<Animator>();
       // Player_health = 50;
    }
    void Update() {
        helthbar.value = Player_health;
        NRGbar.value = Player_NRG;
    }
    private void OnTriggerEnter(Collider other) 
    {
        triggerEvent.Invoke();
        animator.SetTrigger("HitTrigger");
        Debug.Log("player touched the spike!");

          Player_health = Player_health - .25f;
            Debug.Log(Player_health);
        
      //  helthbar
    }
}