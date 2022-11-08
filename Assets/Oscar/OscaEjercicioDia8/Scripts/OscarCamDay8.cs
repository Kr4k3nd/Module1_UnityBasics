using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscarCamDay8 : MonoBehaviour
{
    public Vector3 StartPos, FramePos;
    public Transform Target;
    public bool ModeA;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        ModeA = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Ejercicio 4 la camara mira a la bola
        transform.LookAt(Target);

        //Ejercicio 5 dos modos de camara
        if(Target != null)
        {
            if (ModeA == true)
            {
                transform.position = StartPos;
            }
            else
            {
                transform.position = Target.position + FramePos;
            }
        }

        if (Input.GetMouseButtonDown(0)) { ModeA = !ModeA; }
    }
}
