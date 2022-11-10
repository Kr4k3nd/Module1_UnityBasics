using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_qpalau : MonoBehaviour
{
    public GameObject bullet;    //gameobject que vamos spawnear
    public float cooldown = 1;   //cuenta atrás
    private float resetCooldown; //el valor que va a tener la cuenta atrás cuando reincie
    public Transform waypoint;  //la posición del objeto desde donde va a spawnear la bullet


    // Start is called before the first frame update
    void Start()
    {
        resetCooldown = cooldown; //se guarda el valor para reiniciar la cuenta atrás más tarde 
    }

    // Update is called once per frame
    void Update()
    {
        cooldown = cooldown - 1 * Time.deltaTime; //cada segundo que pasa resta una 

        if (cooldown < 0)  //si la cuenta es menor que

        {

            Instantiate (bullet, waypoint); //spawnea una bala, en la posición de waypoint
            cooldown = resetCooldown;  //reinicia la cuenta
        }

    }

}

