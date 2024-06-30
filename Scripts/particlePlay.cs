using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlePlay : MonoBehaviour
{
    public ParticleSystem[] particles;
    
    void Start()
    {
        particles[0].Play();
        particles[1].Play();
        particles[2].Play();
        particles[3].Play();
    }
}
