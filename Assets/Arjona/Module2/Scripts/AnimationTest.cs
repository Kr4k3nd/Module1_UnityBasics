using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    public Animator anim;
    public bool run;
    public float speed;
    public float jump;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {

        float Xmove = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(Xmove, 0, 0) * Time.deltaTime * speed;


        if (Input.GetButton("Jump"))
        {
            rb.AddForce(new Vector2(0, jump));
        }
        if (Xmove != 0)
        {
            anim.SetBool("speed", true);
        }
        else
        {
            anim.SetBool("speed", false);

        }
    }
}
