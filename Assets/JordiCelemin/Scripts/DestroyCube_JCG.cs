using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube_JCG : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
