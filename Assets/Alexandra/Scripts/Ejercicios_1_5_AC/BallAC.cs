using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAC : MonoBehaviour
{
    public float Speed;         //mención parámetro velocidad
    public GameObject Pop;     //ni papa. Ahhhhh en Pop de Unity va

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Ejercicio 1 La bola se mueve a la izquierda
        transform.position += new Vector3(-Speed, 0, 0) * Time.deltaTime;
        //comprendo lo del vector, falta comprender el (+=) y el significado deltaTime. Le he añadido velocidad en unity de 5.
    }
    private void OnTriggerEnter(Collider other)
    {
        //Ejercicios 2 y 3 La bola se destruye y hace deja un sistema de particulas detras
        Instantiate(Pop, transform.position, Quaternion.identity);
        Destroy(gameObject);

        //En cuanto entre en contacto que pete y se destruya


    }

}
