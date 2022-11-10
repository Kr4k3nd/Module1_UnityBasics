using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_qpalau : MonoBehaviour
{
    public GameObject TargetShoot;
    public float cooldown = 1;
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

            Instantiate(TargetShoot, waypoint);
            cooldown = resetCooldown;
        }

    }

}

