using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer1 : MonoBehaviour
{
    public CanvasUpdateJPerez cVJP;
    public GameObject padre;

    private void OnTriggerEnter(Collider other)
    {
        cVJP.ScoreUpdate();

        Destroy(gameObject);
    }

}
