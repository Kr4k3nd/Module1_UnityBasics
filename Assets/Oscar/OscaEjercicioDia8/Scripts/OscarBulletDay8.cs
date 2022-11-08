using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscarBulletDay8 : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, Speed) * Time.deltaTime;
        Destroy(gameObject, 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
