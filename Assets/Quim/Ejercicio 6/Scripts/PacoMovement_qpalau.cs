using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacoMovement_qpalau : MonoBehaviour
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
        
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(speed, rb.velocity.z, rb.velocity.y);
        }
        
        {
            float Xmove = Input.GetAxisRaw("Horizontal");
            transform.position += new Vector3(Xmove, 0, 0) * Time.deltaTime * speed;
        }
    }
}
