using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviemientoBallXavi : MonoBehaviour
{
    public float jump;
    private Rigidbody rb;           // SCRIPT QUE CONTROLA EL SALTO DE LA BOLA
    private AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Usamos Rigidbody
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector3(0, 0, 0);   // evita que el salto sea exponencial
            rb.AddForce(0, jump, 0);
            audioSource.PlayOneShot(clip);
        }
    }
}
