using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipesPrefab;
    public float cooldown = 3;
    private float resetCooldown;
    public Transform waypoint;

    // Start is called before the first frame update
    void Start()
    {
        resetCooldown = cooldown; // resetcooldown = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
        cooldown = cooldown - 1 * Time.deltaTime;

        if (cooldown < 0)
        {
            Instantiate(pipesPrefab, waypoint);
            cooldown = resetCooldown;          // cooldown = 3
        }


    }
}
