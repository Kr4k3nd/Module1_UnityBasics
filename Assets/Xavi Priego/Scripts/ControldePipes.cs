using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControldePipes : MonoBehaviour
{
    public float speed;             //SCRIP PARA CONTROLAR LA VELOCIDAD DE LAS PIPES

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, 0, 0);
    }
}
