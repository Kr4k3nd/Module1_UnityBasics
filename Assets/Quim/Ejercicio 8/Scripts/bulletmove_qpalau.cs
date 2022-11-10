using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove_qpalau : MonoBehaviour
{
    
    public GameObject Paco;
    public GameObject BulletShoot;
    public Transform waypoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(BulletShoot, transform.position, Quaternion.identity);
        }



    }
}


