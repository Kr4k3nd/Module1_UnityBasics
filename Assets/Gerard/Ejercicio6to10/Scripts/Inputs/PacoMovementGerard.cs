using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacoMovementGerard : MonoBehaviour
{
    // Start is called before the first frame update

    public float xspeed;
    public GameObject paco;
    private Rigidbody rb;

    void Start()
    {
        rb = paco.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = xspeed * Input.GetAxis("Horizontal");
        

        paco.transform.position = new Vector3(paco.transform.position.x + horizontal * Time.deltaTime, paco.transform.position.y, paco.transform.position.z);

    }
}
