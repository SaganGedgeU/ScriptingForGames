using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcescript : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.left * 500);

    }

    void OnCollisionEnter(Collision collisio)
    {
        Debug.Log("collsion with" + collisio.gameObject.name);
        
            rb.AddForce(Vector3.left * 500);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}