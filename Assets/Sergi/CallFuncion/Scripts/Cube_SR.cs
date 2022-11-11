using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_SR : MonoBehaviour
{

    public CanvasUpdate_SR uiUpdate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            uiUpdate.ScoreUpdate();
        }
    }
}
