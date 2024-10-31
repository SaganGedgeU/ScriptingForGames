using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simple_image_behavio : MonoBehaviour
{
    public Slider helthbar;
    public SimpleFloatData Health_data;
   // public Slider helthbar;
    public float helthbar_value;

    // Update is called once per frame

    void update() {
        helthbar_value = Health_data.value;
        Debug.Log("please");
        helthbar.value = 0.5f;
    }
   // public void move_healthbar(float amount)
   // {
     //  helthbar_value = Health_data.value;
        
       // helthbar.value = helthbar_value;

    //}
   
}
