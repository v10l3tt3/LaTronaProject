using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersoShooter : MonoBehaviour
{
    
    public float velocidad = 5f;
    public float multiplicador = 5f;
    float movTeclas;
    private Animator animatorController;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    void Start()
    {
        playerRb = this.GetComponent<Rigidbody2D>();

        animatorController = this.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * velocidad * Time.fixedDeltaTime);  
    }

    void Update()
    {
        float miDeltaTime = Time.deltaTime;

        //MOVIMIENTO
        float movTeclas = Input.GetAxis("Horizontal");

        float moveX = Input.GetAxisRaw("Horizontal");

        transform.Translate(
             movTeclas * (Time.deltaTime * multiplicador),
             0,
             0
        );

        //ANIMACIONES
        animatorController.SetFloat("Horizontal", moveX);
        animatorController.SetFloat("Speed", moveInput.sqrMagnitude);

    }
}
