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

    public bool miraDerecha = true;
    void Start()
    {
        playerRb = this.GetComponent<Rigidbody2D>();

        animatorController = this.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * velocidad * Time.fixedDeltaTime);

        //MOVIMIENTO
        float movTeclas = Input.GetAxis("Horizontal");

        //float moveX = Input.GetAxisRaw("Horizontal");

        transform.Translate(
             movTeclas * (Time.deltaTime * multiplicador),
             0,
             0
        );
        
        //Animacion IDLE TO WALKING
        if (movTeclas != 0)
        {
            animatorController.SetBool("WalkH", true);
        }
        else
        {
            animatorController.SetBool("WalkH", false);
        }
        
        //Aprox2 de FLIP(ambas direcciones)
        if(movTeclas < 0){
            this.GetComponent<SpriteRenderer>().flipX = true;
            miraDerecha = false;
        }else if(movTeclas > 0){
            this.GetComponent<SpriteRenderer>().flipX = false;
            miraDerecha = true;
        }
    }

    void Update()
    {
        float miDeltaTime = Time.deltaTime;



    }
}
