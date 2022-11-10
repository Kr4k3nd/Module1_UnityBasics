using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer_qpalau : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
