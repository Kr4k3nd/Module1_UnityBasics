using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybulletAC : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))        //clic left mouse button
        {
            Instantiate(bullet, transform.position, Quaternion.identity);   //activate bullet
        }
    }
}
