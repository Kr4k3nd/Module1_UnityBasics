using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscarTempObj : MonoBehaviour
{
    public float Goal;
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, Goal);
    }
}
