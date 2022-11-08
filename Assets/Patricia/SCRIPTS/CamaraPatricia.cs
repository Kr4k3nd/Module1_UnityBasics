using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPatricia : MonoBehaviour
{
    public new GameObject camera;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        //suda
    }

    // Update is called once per frame
    private void Update()
    {

        camera.transform.LookAt(target.transform.position);
        
    }
}
