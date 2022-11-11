using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ClicAC : MonoBehaviour
{
    public GameObject BulletAC;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))                    //Clic left mouse button
        {
            Instantiate(BulletAC, transform.position, Quaternion.identity);     //Instant bullet
        }
    }
}
