using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Mathf.PingPong(t: Time.time, length: 3);
        var p = new Vector3(x: 0, x, z: 0);
        transform.position = p;
    }
}
