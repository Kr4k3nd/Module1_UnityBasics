using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
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
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(BulletShoot, transform.position, Quaternion.identity);
        }



    }
}
