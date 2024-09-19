using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcescript : MonoBehaviour
{
    private Rigidbody rb;
    public float bounceForce = 6f;
    public Color newColor = Color.red;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // rb.AddForce(Vector3.left * 500);
    }

    void OnCollisionEnter(Collision collisio)
    {
        Debug.Log("collsion with" + collisio.gameObject.name);
        GetComponent<Renderer>().material.color = newColor;

            rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        
    }
   
}