using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAC : MonoBehaviour
{
    public float Speed;                               //mención parámetro velocidad
    public GameObject RodilloAC;                      //objeto a instanciar
    public Transform waypoint2;                      //punto a instanciar

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -Speed) * Time.deltaTime;       //el objeto se mueve en esa dirección
    }
}
