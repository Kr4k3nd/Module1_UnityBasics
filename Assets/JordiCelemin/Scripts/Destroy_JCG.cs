using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_JCG : MonoBehaviour
{  //Ejercicio 3
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
