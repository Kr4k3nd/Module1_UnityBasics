using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacoMovement_JCG : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;
    
    private int h;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Xmove = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(Xmove, 0, 0) * Time.deltaTime * speed;

    }
}
