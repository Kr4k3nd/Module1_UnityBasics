using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMeta : MonoBehaviour
{

    public ParticleSystem goal;
    public bool activator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            goal.Play();
        Debug.Log("Entry");
    }



    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

    }
}