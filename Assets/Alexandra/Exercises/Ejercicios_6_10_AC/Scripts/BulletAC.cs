using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAC : MonoBehaviour
{
    //move bullet
    public float Speed;         //mención parámetro velocidad
    public GameObject parent;
    public CanvasUpdatePacoAC cVBAC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, Speed * Time.deltaTime);      //move bullet on Z
        Destroy(parent, 1);                                                  //destroy bullet
    }
    private void OnTriggerEnter(Collider other)     //when collision destroy and score
    {
        cVBAC.ScoreUpdate();        //Score on canvasAC
        Destroy(parent);            //destroy parent (object)
    }

}
