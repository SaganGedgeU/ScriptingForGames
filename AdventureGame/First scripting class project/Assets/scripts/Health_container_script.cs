using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_container_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public SimpleFloatData Health_data;
    // Update is called once per frame
    public void ReduceHealth(float amount) {
        Health_data.UpdateValue(amount);
       
    }
}
