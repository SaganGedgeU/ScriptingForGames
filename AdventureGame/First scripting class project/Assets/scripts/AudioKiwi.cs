using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioKiwi : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}