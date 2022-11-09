using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement_JCG : MonoBehaviour
{
    //Ejercicio  1
    private Rigidbody rb; //para las fisicas 

    
    public float speed; //para correr

    private int h; //horizontal
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //para cuando empiece tenga fisicas
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3(-3, 0, 0);  //para que tenga velicidad en -3 en cordenadas de horizontal
           
        }
        
    }
}
