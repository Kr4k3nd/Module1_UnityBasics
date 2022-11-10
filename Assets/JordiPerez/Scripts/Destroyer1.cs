using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer1 : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 2);
    }

}
