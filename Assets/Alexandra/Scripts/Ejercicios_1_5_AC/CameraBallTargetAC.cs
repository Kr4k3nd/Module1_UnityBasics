using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBallTargetAC : MonoBehaviour
{
    public Transform target;
    public Vector3 StartPos, FramePos;
    public bool ModeA;

    void Start()
    {
        StartPos = transform.position;
        ModeA = true;
    }

    // Update is called once per frame
    void Update()

    {
        transform.LookAt(target);

        if (target != null)
        {
            if (ModeA == true)

            {
                transform.position = StartPos;
            }
            else
            {
                transform.position = target.position + FramePos;
            }
        }
        //Aquí indicamos que con el clic se lleve a cabo la acción
        if (Input.GetMouseButtonDown(0)) { ModeA = !ModeA; }

        }
}
