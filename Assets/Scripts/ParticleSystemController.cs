using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemController : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public float Delay = 0;

    // Start is called before the first frame update
    void Start()
    {
        var main = particleSystem.main;
        main.startDelay = Delay;
    }

    public void PlayParticles()
    {
        particleSystem.Play();
    }

    public void StopParticles()
    {
        particleSystem.Stop();
        particleSystem.Clear();
    }
}
