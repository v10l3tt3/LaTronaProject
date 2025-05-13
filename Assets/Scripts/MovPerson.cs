using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPerson : MonoBehaviour
{
    public Vector3 posInicial;

    public float velocidad = 5f;
    public float multiplicador = 5f;

    public bool miraDerecha = true;
    

    float movTeclas;
    float movTeclasY;
    private Rigidbody2D rb;
    private Animator animatorController;
    void Start()
    {
        this.GetComponent<Transform>().position = posInicial;
        //rb = this.GetComponent<Rigidbody2D>();

        animatorController = this.GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        //v.mov del perso
        //rb.velocity = new Vector2(movTeclas*multiplicador, rb.velocity.y);
        
        
    }
    
    void Update()
    {
        float miDeltaTime = Time.deltaTime; 

        //WASD, ya si funciona en cruz
        float movTeclas = Input.GetAxis("Horizontal");
        float movTeclasY = Input.GetAxis("Vertical");
       

        transform.Translate(
             movTeclas*(Time.deltaTime*multiplicador),
             movTeclasY*(Time.deltaTime*multiplicador), 
             0
        );
      

        //FLIP en eje X
        if(movTeclas < 0){
            this.GetComponent<SpriteRenderer>().flipX = true;
            miraDerecha = false;
        }else if(movTeclas > 0){
            this.GetComponent<SpriteRenderer>().flipX = false;
            miraDerecha = true;
        }

        //Animacion IDLE TO WALKING
        /*if(movTeclas != 0){
            animatorController.SetBool ("activateWalk",true);
        }else{
            animatorController.SetBool ("activateWalk",false);
        }*/
       
    }

    void OnTriggerEnter2D(Collider2D col){
        //cambiar a estado burbuja, snapshot burbuja
        /*if(col.name == "Burbuja"){
            //disparo burbuja
            AudioManager.Instance.IniciarEfectoBurbuja();
        }*/
    }
    void OnTriggerExit2D(Collider2D col){
        //reestablecer snapshot predefinido
        /*if(col.name == "Burbuja"){
            //disparo burbuja
            AudioManager.Instance.IniciarEfectoDefault();
        }*/
    }

    /*void ColorChange(){

        if(iAmRed){
            this.GetComponent<SpriteRenderer>().color = Color.white;
            iAmRed = false;
        }else{
            this.GetComponent<SpriteRenderer>().color = Color.red;
            iAmRed = true;
        }
    }*/
}
