using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementGerard : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;    // hago público el parametro speed
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, 0, 0);     // hago que la posición en el vector x se transforme al valor negativo de X que ponga en speed multiplicado por el reloj del procesador
    }
}
