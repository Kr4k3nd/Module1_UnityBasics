using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    public float speed;
    public float jump;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        
        {
            float Xmove = Input.GetAxisRaw("Horizontal");
            transform.position += new Vector3(Xmove, 0, 0) * Time.deltaTime * speed;
        }
    }

}
 



