using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem particle_System; // Reference to the Particle System
    public int FirstEmisionAmount = 10; // Exposed variable for particle amount
    public int SecondEmisionAmount = 20;
    public int ThirdEmisionAmount = 30;
    public float delayBetweemEmissions = 0.5f;



    private void Start()
    {
        particle_System = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) // Check if the player triggered the event
        {
            StartCoroutine(EmitParticlesCoroutine());
        }
    }

    private IEnumerator EmitParticlesCoroutine()
    {
        particle_System.Emit(FirstEmisionAmount);
        yield return new WaitForSeconds(delayBetweemEmissions);// Emit the specified amount of particles

        particle_System.Emit(SecondEmisionAmount);
        yield return new WaitForSeconds(delayBetweemEmissions);

        particle_System.Emit(ThirdEmisionAmount);

    }
}