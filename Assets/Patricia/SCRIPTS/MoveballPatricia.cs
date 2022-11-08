using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveballPatricia : MonoBehaviour
{
    private Rigidbody rb;
    public float speed; //-> Velocitat

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //usa el rigidbody
    }

    // Update is called once per frame
    void Update()
       
    {
        rb.velocity = new Vector3(-speed, 0, 0);
        // --> que se mueva hacia la izquierda sin input, usando to rb
    }
}
