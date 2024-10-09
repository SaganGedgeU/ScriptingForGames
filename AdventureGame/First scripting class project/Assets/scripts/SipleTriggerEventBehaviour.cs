using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SipleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other) 
    {
        triggerEvent.Invoke();
        Debug.Log("player touched the spike!");
    }
}