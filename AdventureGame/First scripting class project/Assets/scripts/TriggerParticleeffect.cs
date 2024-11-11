using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem newParticleSystem; // Reference to the Particle System
    public int particleAmount = 10; // Exposed variable for particle amount

    private void Start()
    {
        newParticleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) // Check if the player triggered the event
        {
            newParticleSystem.Emit(particleAmount); // Emit the specified amount of particles
        }
    }
}