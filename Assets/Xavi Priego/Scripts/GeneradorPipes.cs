using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPipes : MonoBehaviour
{
    public GameObject pipesPrefab;    //ESTE SCRIPT HACE SPAWN DE LAS PIPES 
    public float cooldown;
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
            Instantiate(pipesPrefab, waypoint);
            cooldown = resetCooldown;
        }
    }
}
