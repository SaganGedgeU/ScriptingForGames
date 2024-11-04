using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_container_script : MonoBehaviour
{
    public SimpleFloatData healthData;

    public void ReduceHealth(float amount)
    {
        healthData.UpdateValue(amount);
    }
}