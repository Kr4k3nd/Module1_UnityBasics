using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClashPatricia : MonoBehaviour
{
    public ParticleSystem goal;
    public bool activator;
    private Rigidbody rb; //<- acuerdate de decirle siempre el que
    public GameObject ball;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
     
        if (other.tag == "Player")
        {
            goal.Play();
            Debug.Log("Extra");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

// void DestroyGameObject(Collider other) (como no sale tira a otro script)
   