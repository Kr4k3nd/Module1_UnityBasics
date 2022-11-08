using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb; 
    

    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed, rb.velocity.z, rb.velocity.y);
        }
    }
}
