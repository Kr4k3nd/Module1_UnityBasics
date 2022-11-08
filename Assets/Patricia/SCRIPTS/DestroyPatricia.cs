using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPatricia : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) //ocurre cuando en trigger

    {
       if (other.tag == "Player") //only if if the tagged object enters
        {
            Destroy(other.gameObject);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
       
    }
}
