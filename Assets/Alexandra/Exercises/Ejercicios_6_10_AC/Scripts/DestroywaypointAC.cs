using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroywaypointAC : MonoBehaviour      //destroy cube
{
    // Start is called before the first frame update
  
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 3f);        //que se destruya cuando pase 1segundo
    }
}
