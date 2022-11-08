using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController_SR : MonoBehaviour
{
    public GameObject Cube;
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
