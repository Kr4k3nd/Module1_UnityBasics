using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FX_Ball_SR : MonoBehaviour
{
    public ParticleSystem touch;
    public bool END = false;

   //Esta parte del codigo utilizamos un trigger que no tiene que estar en el Update  ya que actua en conseucnete a una accion
    private void OnTriggerEnter(Collider other)
    {
        if(END == false)
        {
            touch.Play();
            Debug.Log("Final");
        }
        END = true;
    }

 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}

