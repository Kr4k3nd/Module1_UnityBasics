using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetsGerard : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject TargetShoot;
    public float cooldown = 3;
    private float resetCooldown;
    public Transform waypoint;

    void Start()
    {
        resetCooldown = cooldown;  
    }

    // Update is called once per frame
    void Update()
    {
        cooldown = cooldown - 1 * Time.deltaTime;
        if(cooldown<0)
        {
            Instantiate(TargetShoot, waypoint);
            cooldown = resetCooldown;
        }

    }
}
