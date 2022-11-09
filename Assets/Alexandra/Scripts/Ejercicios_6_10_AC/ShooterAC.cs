using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterAC : MonoBehaviour
{
    //Disparo cubo
    public GameObject Target;       //mención objetivo
    public Transform waypoint;      //punto referencia

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Target, transform.position, Quaternion.identity);
        }
    }
}
