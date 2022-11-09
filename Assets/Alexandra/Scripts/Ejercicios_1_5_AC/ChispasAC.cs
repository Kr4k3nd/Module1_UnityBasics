using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChispasAC : MonoBehaviour
{
    public ParticleSystem touch;
    public bool END = false;

    //Esta parte del codigo utilizamos un trigger que no tiene que estar en el Update  ya que actua en consecuencia a una accion

    private void OnTriggerEnter(Collider other)
    {
        if (END == false)
        {
            touch.Play();
            Debug.Log("Final");
        }
        END = true;
    }
    //ni papa lo que significa. Entiendo que te sale un mensaje cuando sucede la acción de impacto.




        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
