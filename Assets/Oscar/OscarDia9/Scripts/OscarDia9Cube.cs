using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscarDia9Cube : MonoBehaviour
{
    public CanvasUpdateOscar MyUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            MyUI.ScoreUpdate();
        }

        //if(MyUI.Prueba == true)
        //{
        //    MyUI.Prueba().score *= 2;
        //}
    }
}
