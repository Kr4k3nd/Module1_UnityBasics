using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OscarDia9Nave : MonoBehaviour
{
    public int Life, MaxLife;
    public float Speed, GunTimer, GunGoal;
    public Transform CanonPoint;
    public GameObject Ammo, Pop;
    public Text LifeLabel;

    // Start is called before the first frame update
    void Start()
    {
        //FPS Limit
        Application.targetFrameRate = 30;
        Life = MaxLife;
        LifeLabel.text = Life.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento
        float MoveX = Input.GetAxisRaw("Horizontal");
        float MoveY = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(MoveX, MoveY, 0).normalized * Speed * Time.deltaTime;

        //Disparo
        if(GunTimer < GunGoal) { GunTimer += Time.deltaTime; }

        if (Input.GetButton("Fire1") && GunTimer >= GunGoal)
        {
            Instantiate(Ammo, CanonPoint.position, Quaternion.identity);
            GunTimer = 0;
        }

        //Muerte
        if (Life <= 0)
        {
            Instantiate(Pop, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    //Recibir daño
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Life -= 1;
        }
        LifeLabel.text = Life.ToString();
    }
}
