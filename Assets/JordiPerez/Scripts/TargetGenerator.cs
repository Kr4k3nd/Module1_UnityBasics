using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{

    public GameObject Diana;
    public float cooldown = 3;
    private float resetCooldown;
    public Transform waypoint;
    


    // Start is called before the first frame update
    void Start()
    {
        resetCooldown = cooldown;
        
    }

    

    // Update is called once per frame
    void Update()
    {
        cooldown = cooldown - 1 * Time.deltaTime;

        if (cooldown < 0)
        {
            Instantiate(Diana, waypoint);
            cooldown = resetCooldown;          // cooldown = 3


        }



        
    }



}

