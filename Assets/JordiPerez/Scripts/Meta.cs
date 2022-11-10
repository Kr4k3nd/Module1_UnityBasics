using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public ParticleSystem goal;
    public bool activator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            goal.Play();
        Debug.Log("Entra");
    }



    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
