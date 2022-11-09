using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraDanae : MonoBehaviour
{
    public GameObject camera;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.LookAt(target.transform.position);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            foreach (RaycastHit hit in Physics.RaycastAll(ray))
            {
                if (hit.transform.gameObject.tag == "Player")
                { }
            }
        }
    }
}
