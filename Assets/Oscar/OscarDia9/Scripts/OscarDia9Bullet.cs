using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscarDia9Bullet : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves to it's forward. Trajectory can be modified by rotating
        transform.position += transform.right * Time.deltaTime * Speed;
        Destroy(gameObject, 3);
    }

    //Destroyed on contact
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
