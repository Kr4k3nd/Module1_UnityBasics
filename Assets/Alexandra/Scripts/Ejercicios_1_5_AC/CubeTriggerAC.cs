using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTriggerAC : MonoBehaviour
{
    public ParticleSystem particles;
    
    private void OnTriggerEnter(Collider other)     // hacemos que cuando entre en Trigger por colisión haga lo siguiente:
    {
        particles.Play();
        Destroy(other.gameObject);              // destruye el objeto del juego
    }
}
