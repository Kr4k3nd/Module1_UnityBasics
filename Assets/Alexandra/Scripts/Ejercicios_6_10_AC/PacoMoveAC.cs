using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacoMoveAC : MonoBehaviour
{

    public GameObject PacoAC;     //mover el objeto indicado Paco pa los amigos
    public Rigidbody rb;         //mención rigidbody
    public float Speed;         //mención parámetro velocidad

    // Start is called before the first frame update
    void Start()
    {
        rb = PacoAC.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
        

    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(Speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(-Speed, 0, 0);
        }
    }
   
}
