using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    public GameObject targetchildOne;
    public GameObject targetchildTwo;
    public GameObject targetchildthree;
    public GameObject targetchildFour;
    public GameObject Diagone;
    public GameObject Diagtwo;
    public GameObject Diagthree;
    public GameObject Diagfour;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        MoveSheres();


    }

    void MoveSheres() {

        var x = Mathf.PingPong(t: Time.time, length: 3);
        var p = new Vector3(x: 0, x, z: 0);
        var q = new Vector3(x: x, 0, z: 0);
        var u = new Vector3(x: x, x, z: 0);
        var v = new Vector3(x: x, -x, z: 0);


        targetchildOne.transform.position = p;
        targetchildTwo.transform.position = -p;
        targetchildthree.transform.position = q;
        targetchildFour.transform.position = -q;
        Diagone.transform.position = u;
        Diagtwo.transform.position = -u;
        Diagthree.transform.position = v;
        Diagfour.transform.position = -v;
    }
}
