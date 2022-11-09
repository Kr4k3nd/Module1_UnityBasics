using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta_JCG : MonoBehaviour
{
    public ParticleSystem goal;  //sistema de particulas
    public bool activator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            goal.Play();
        Debug.Log("Entra");
    }

    //Ejercicio 2

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

    }

}
