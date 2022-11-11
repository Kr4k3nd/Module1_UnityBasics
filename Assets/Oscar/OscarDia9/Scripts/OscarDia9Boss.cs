using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscarDia9Boss : MonoBehaviour
{
    //Function
    public int Life, MaxLife;
    public List<Transform> Canon;
    public GameObject Ammo, Pop;
    public float GunTimer, GunGoal;
    public int CurrAtk;
    public List<int> AtkPatern;

    //Appearence
    public Animator Anim1, Anim2, Anim3;
    public Vector3 MyPos;

    // Start is called before the first frame update
    void Start()
    {
        Life = MaxLife;
        Anim1.SetInteger("ID", 0);
        Anim2.SetInteger("ID", 1);
        Anim3.SetInteger("ID", 2);
        CurrAtk = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Moving to it's position
        if (transform.position != MyPos)
        {
            transform.position = Vector3.Lerp(transform.position, MyPos, 0.06f);
        }

        //Death when life reachs 0
        if (Life <= 0)
        {
            Instantiate(Pop, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        //Counting time for next attack
        GunTimer += Time.deltaTime;
        //Executing one attack, chosen acording to the attack patern
        if (GunTimer >= GunGoal)
        {
            if(AtkPatern[CurrAtk] == 0)
            {
                AttackA();
            }
            if (AtkPatern[CurrAtk] == 1)
            {
                AttackB();
            }
            if (AtkPatern[CurrAtk] == 2)
            {
                AttackC();
            }
            if (AtkPatern[CurrAtk] == 3)
            {
                AttackD();
            }
            if (AtkPatern[CurrAtk] == 4)
            {
                AttackE();
            }
            if (AtkPatern[CurrAtk] == 5)
            {
                AttackF();
            }
            //Resets
            GunTimer = 0;
            CurrAtk += 1;
            if(CurrAtk >= AtkPatern.Count) { CurrAtk = 0; }
        }

    }

    //Attacks in Paperfan
    public void AttackA()
    {

        Instantiate(Ammo, Canon[1].position, Quaternion.Euler(0, 180, 10));

        Instantiate(Ammo, Canon[3].position, Quaternion.Euler(0, 180, 0));

        Instantiate(Ammo, Canon[5].position, Quaternion.Euler(0, 180, -10));

    }

    public void AttackB()
    {
        Instantiate(Ammo, Canon[0].position, Quaternion.Euler(0, 180, 15));

        Instantiate(Ammo, Canon[2].position, Quaternion.Euler(0, 180, 5));

        Instantiate(Ammo, Canon[4].position, Quaternion.Euler(0, 180, -5));

        Instantiate(Ammo, Canon[6].position, Quaternion.Euler(0, 180, -15));
    }

    public void AttackC()
    {

        Instantiate(Ammo, Canon[1].position, Quaternion.Euler(0, 180, 10));
        Instantiate(Ammo, Canon[2].position, Quaternion.Euler(0, 180, 5));
        Instantiate(Ammo, Canon[3].position, Quaternion.Euler(0, 180, 0));
        Instantiate(Ammo, Canon[4].position, Quaternion.Euler(0, 180, -5));
        Instantiate(Ammo, Canon[5].position, Quaternion.Euler(0, 180, -10));

    }

    public void AttackD()
    {
        Instantiate(Ammo, Canon[0].position, Quaternion.Euler(0, 180, 15));
        Instantiate(Ammo, Canon[1].position, Quaternion.Euler(0, 180, 10));
        Instantiate(Ammo, Canon[2].position, Quaternion.Euler(0, 180, 5));
        Instantiate(Ammo, Canon[3].position, Quaternion.Euler(0, 180, 0));
        Instantiate(Ammo, Canon[4].position, Quaternion.Euler(0, 180, -5));
        Instantiate(Ammo, Canon[5].position, Quaternion.Euler(0, 180, -10));
        Instantiate(Ammo, Canon[6].position, Quaternion.Euler(0, 180, -15));
    }

    //Other attacks
    public void AttackE()
    {
        Instantiate(Ammo, Canon[0].position, Quaternion.Euler(0, 180, -15));





        Instantiate(Ammo, Canon[6].position, Quaternion.Euler(0, 180, 15));
    }

    public void AttackF()
    {
        Instantiate(Ammo, Canon[0].position, Quaternion.Euler(0, 180, 15));
        Instantiate(Ammo, Canon[1].position, Quaternion.Euler(0, 180, -10));
        


        Instantiate(Ammo, Canon[5].position, Quaternion.Euler(0, 180, 10));
        Instantiate(Ammo, Canon[6].position, Quaternion.Euler(0, 180, -15));
    }

    //Recive damage + Choose a new position when hit
    private void OnTriggerEnter(Collider other)
    {
        MyPos = new Vector3(Random.Range(3, 8), Random.Range(-3, 3), 0);
        if (other.tag == "Bullet")
        {
            Life -= 1;
        }
    }
}
