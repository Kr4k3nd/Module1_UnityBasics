using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAC : MonoBehaviour
{
    public CanvasUpdateAC uiUpdate;      //buscamos comunicar variables entre scripts, por eso tiene que ser la variable public


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //aquí ponemos el input para el script del canvas
        if (Input.GetButtonDown("Jump"))
        {
            uiUpdate.ScoreUpdate();       
        }

    }
}
