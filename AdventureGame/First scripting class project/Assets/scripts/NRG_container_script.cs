

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NRG_container_script : MonoBehaviour
{
    public SimpleFloatData NRGData;

    public void ReduceNRG(float amount)
    {
        NRGData.UpdateValue(amount);
    }
}
