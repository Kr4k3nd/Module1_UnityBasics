using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaveItchControl : MonoBehaviour
{
    //OJO al nombre del script
    public float Speed, Cool, CoolGoal;
    public Transform Canon;
    public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ejercicio 6: Movimiento con teclas
        float Xmove = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(Xmove, 0, 0) * Time.deltaTime * Speed;

        //Ejercicio 8: disparo
        if(Cool < CoolGoal) { Cool += Time.deltaTime; }
        if (Input.GetButtonDown("Fire1") && Cool >= CoolGoal)
        {
            Instantiate(Bullet, Canon.position, Quaternion.identity);
            Cool = 0;
        }
    }
}
