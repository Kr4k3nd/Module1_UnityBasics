using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacoController_SR : MonoBehaviour
{
    [Header("Movement")]

    public float moveSpeed;     //Es publico para ajustar desde Unity la velocidad

    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [Header("Keybinds")]

    public KeyCode jumpKey = KeyCode.Space;

    [Header ("Ground Checker")]

    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;   

    float horizontalInput;      //Eje horizontal para el movimiento
    float verticalInput;        //Eje vertical para el movimeinto

    Vector3 moveDirection;      // Vector 3 para escoger entre x,y,z 

    Rigidbody rb;               // Seleciona el Rigidboy de la interfaz de Unity para tener constancia de que existe

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        // Ground checker para ver si el personaje esta en el aire
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        MyInput();
        SpeedControl();

        //Para controlar el arrastrar

        if (grounded)
            rb.drag = groundDrag;
        else
            rb.drag = 0;

    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //cuando salta

        if(Input.GetKey(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump),jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        //Calcula el movimeinto del jugador
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

            //En el suelo
            if(grounded)
            {
                rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
            }
            else if(!grounded)
            {
                rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
            }
                
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //Limitador de velocidad

        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, rb.velocity.z);
        }
    }

    private void Jump()
    {
        // reset la velocidad de Y
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);

    }

    private void ResetJump()
    {
        readyToJump = true;
    }
}
