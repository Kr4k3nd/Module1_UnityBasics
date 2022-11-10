using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscarDia9Enemy : MonoBehaviour
{
    public int Life, MaxLife;
    public Transform CanonPoint;
    public GameObject Ammo, Pop;
    public float GunTimer, GunGoal;
    public Vector3 MyPos;

    // Start is called before the first frame update
    void Start()
    {
        Life = MaxLife;
        MyPos = new Vector3(Random.Range(2, 8), Random.Range(-4, 4), 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Moving to it's position
        if (transform.position != MyPos)
        {
            transform.position = Vector3.Lerp(transform.position, MyPos, 0.1f);
        }

        //Death when life reachs 0
        if (Life <= 0)
        {
            Instantiate(Pop, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        //Shooting
        GunTimer += Time.deltaTime;
        if(GunTimer >= GunGoal)
        {
            Instantiate(Ammo, CanonPoint.position, Quaternion.Euler(0,180,0));
            GunTimer = 0;
        }
    }

    //Choosing a new position when colliding with something
    private void OnCollisionEnter(Collision collision)
    {
        MyPos = new Vector3(Random.Range(2, 8), Random.Range(-4, 4), 0);
    }
    //Recive damage when hit
    private void OnTriggerEnter(Collider other)
    {
        MyPos = new Vector3(Random.Range(2, 8), Random.Range(-4, 4), 0);
        if (other.tag == "Bullet")
        {
            Life -= 1;
        }
    }
}
