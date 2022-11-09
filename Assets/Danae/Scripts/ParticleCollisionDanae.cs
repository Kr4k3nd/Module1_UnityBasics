
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollisionDanae : MonoBehaviour
{
    public ParticleSystem goal;
    public bool activator;
    Rigidbody rb; // acuerdese del is trigger

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            goal.Play();
            Debug.Log("Esto funciona");
        }
        if (other.tag =="Suelo")
        {
            activator = false;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
