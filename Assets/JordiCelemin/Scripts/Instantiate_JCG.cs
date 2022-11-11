using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_JCG : MonoBehaviour
{
    public GameObject prefabToinstantiate;  // objeto a instanciar
    public Transform waypoint;         //sitio en el que vamos a instanciarlo

    public float time;       //tiempo en que va a tardar en instanciarse
    private float resetTime;    // valor de reseteo de tiempo
    // Start is called before the first frame update
    void Start()
    {
        resetTime = time;   // se le asigna el valor de reinicia
    }

    // Update is called once per frame
    void Update()
    {
        time = time - 1 * Time.deltaTime; // me resta 1 unidad cada segundo que pase
        
        if(time < 0)
        {
            Instantiate(prefabToinstantiate, waypoint);
            time = resetTime;
        }
    }
}
