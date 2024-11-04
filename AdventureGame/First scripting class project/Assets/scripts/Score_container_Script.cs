using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_container_Script : MonoBehaviour
{
    public SimpleIntData scoreData;

    public void Addpoint(int amount) 
    { 
    scoreData.UpdateValue(amount);
    }
}
