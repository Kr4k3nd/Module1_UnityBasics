using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTriggerGerard : MonoBehaviour
{
    // Start is called before the first frame update

    public ParticleSystem boom;

    private void OnTriggerEnter(Collider other)
    {
        boom.Play();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
