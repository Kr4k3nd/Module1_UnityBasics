using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTriggerGerard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)     // hacemos que cuando entre en Trigger por colisi�n haga lo siguiente:
    {
        Destroy(other.gameObject);              // destruye el objeto del juego
    }

}
