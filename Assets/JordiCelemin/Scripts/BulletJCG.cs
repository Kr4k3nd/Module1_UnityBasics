using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletJCG : MonoBehaviour
{
    public float Speed;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, Speed * Time.deltaTime);
        Destroy(parent, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(parent);
    }
}
