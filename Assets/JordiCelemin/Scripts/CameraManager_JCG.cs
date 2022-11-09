using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager_JCG : MonoBehaviour
{
    public Transform target;
    
    public bool ModeA;

    public Vector3 StartPos, FramePos;


    // Update is called once per frame
    void LateUpdate()
    {                             //Ejericio 4 y 5
        transform.LookAt(target);
       if(target != null)
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

        if (Input.GetMouseButtonDown(0)) { ModeA = !ModeA; }
    }
}
