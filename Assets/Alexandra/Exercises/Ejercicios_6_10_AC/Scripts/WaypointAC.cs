using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAC : MonoBehaviour
{
    public GameObject TargetAC;                     //objeto a instanciar
    public Transform waypoint;                      //punto a instanciar

    public float time;                              //el tiempo a instanciar
    private float resetTime;                        //reset tiempo    

    // Start is called before the first frame update
    void Start()
    {
        resetTime = time;                           //asignamos que resete el valor, en este caso el tiempo
    }

    // Update is called once per frame
    void Update()
    {
        time = time - 1 * Time.deltaTime;           //restará 1u/s

        if (time < 0)                                //si el tiempo es <0
        {
            Instantiate(TargetAC, waypoint);         //mueve el objetivo al punto indicado
            time = resetTime;                        //una vez hecho resetea la cuenta
        }


    }
}
