using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementDanae : MonoBehaviour
{
    public GameObject camera;
    public GameObject target;
    //public Collider cd;
   // private DestroyerDanae dd;


    //public GameObject tD;

   /* private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Debug.Log("Le dí owo");
        }
    }
    void Start()
    {

    }
   

    // Update is called once per frame
    private void Update()
    {
        if (dd.targetDestroyed == false)
        {
            camera.transform.LookAt(target.transform.position);
        }

        if (dd.targetDestroyed == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
    /*
    cd = GetComponent<Collider>();

     camera.transform.LookAt(target.transform.position);

    GameObject.Find("public static bool targetDestroyed").GetComponent<DestroyerDanae>();
    {
        if ((dd.GetComponent(targetDestroyed.bool) = false)
        {
            camera.transform.LookAt(target.transform.position);
        }
        if (true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }


    }*/
}
