using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerDanae : MonoBehaviour
{
    public bool targetDestroyed = false;

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);          
            targetDestroyed = true;
            Debug.Log("Es cierto, me destuí uwu");
        };
 
            
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Esto es falso uwu");
    }


}
