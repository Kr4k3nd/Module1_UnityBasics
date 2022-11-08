using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_SR : MonoBehaviour
{
    public Transform target;
    public bool isOn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (isOn == true)
        {
            transform.LookAt(target);
        }
        else
        {
            this.transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
        }

        if (Input.GetMouseButtonDown(0))
        {
            isOn = !isOn;
        }
       
    }
}
