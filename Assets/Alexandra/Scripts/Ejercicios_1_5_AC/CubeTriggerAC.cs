using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTriggerAC : MonoBehaviour
{
    public GameObject Cube;
    private Rigidbody rb;
    public float speed;

    private void OnTriggerEnter(Collider other)     // hacemos que cuando entre en Trigger por colisión haga lo siguiente:
    {
        Destroy(other.gameObject);              // destruye el objeto del juego
    }
}
