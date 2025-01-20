using UnityEngine;

public class effects : MonoBehaviour
{
    [Header("Particle Effects")]
    [SerializeField] private ParticleSystem particleSys;

    [Header("Audio Source")]
    [SerializeField] private AudioSource audio;
    public void PlayAudio()
    {
            audio.Play();
    }

    public void ParticleEffect()
    {
        particleSys.Play();
    }
}
