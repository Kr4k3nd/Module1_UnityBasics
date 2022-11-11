using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow_qpalau : MonoBehaviour
{

    public Vector3 StartPos, FramePos;
    public Transform target;
    public bool lookAt = false;
    public bool ModeA;

    private void Start()
    {
        StartPos = transform.position;
        ModeA = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(target);
        if (true)
        {
            transform.LookAt(target);
        }

        if (ModeA == true)
        {
            transform.position = StartPos;

        }
        else
        {
            transform.position = target.position + FramePos;
        }

        if (Input.GetMouseButtonDown(0)) { ModeA = !ModeA; }
    }




}