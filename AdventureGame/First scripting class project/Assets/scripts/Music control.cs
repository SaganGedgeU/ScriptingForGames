using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musiccontrol : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource musicSource;
   public void ToggleMusic()
    {
        if (musicSource.isPlaying)
        {
            musicSource.Pause();
        }else
        {
            musicSource.Play(); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
