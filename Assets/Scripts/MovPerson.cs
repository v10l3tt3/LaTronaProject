using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class MovPerson : MonoBehaviour
{
    //OLD RB - public Vector3 posInicial;
    //public float multiplicador = 5f;
    [SerializeField] public float velocidad = 5f;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;



    public bool miraDerecha = true;


    public float movTeclas;
    public float movTeclasY;

    //animaciones APROX2
    private Animator playerAnimator;

    void Start()
    {
        //OLD RB
        //this.GetComponent<Transform>().position = posInicial;
        playerRb = this.GetComponent<Rigidbody2D>();

        //animaciones APROX2
        playerAnimator = this.GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        //v.mov del perso
        //rb.velocity = new Vector2(movTeclas*multiplicador, rb.velocity.y);

        playerRb.MovePosition(playerRb.position + moveInput * velocidad * Time.fixedDeltaTime);


    }

    void Update()
    {
        float miDeltaTime = Time.deltaTime;

        //WASD, ya si funciona en cruz
        /*float movTeclas = Input.GetAxis("Horizontal");
        float movTeclasY = Input.GetAxis("Vertical");
        
        transform.Translate(
             movTeclas*(Time.deltaTime*multiplicador),
             movTeclasY*(Time.deltaTime*multiplicador), 
             0
        );*/

        //Aprox2
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveX, moveY).normalized;


        //PARA HACER animaciones APROX2
        playerAnimator.SetFloat("Horizontal", moveX);
        playerAnimator.SetFloat("Vertical", moveY);
        playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnimator.SetBool("InteractWithSpace", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnimator.SetBool("InteractWithSpace", false);
        }

        GuardarPosicion();
        CargarPosicion();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //cambiar a estado burbuja, snapshot burbuja
        /*if(col.name == "Burbuja"){
            //disparo burbuja
            AudioManager.Instance.IniciarEfectoBurbuja();
        }*/
    }
    void OnTriggerExit2D(Collider2D col)
    {
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
    
    public void GuardarPosicion() {
        PlayerPrefs.SetFloat("posicionX", transform.position.x);
        PlayerPrefs.SetFloat("posicionY", transform.position.y);
        PlayerPrefs.SetFloat("posicionZ", transform.position.z);
    }

        //Cargar la posición del jugador
    public void CargarPosicion() {
        float posX = PlayerPrefs.GetFloat("posicionX");
        float posY = PlayerPrefs.GetFloat("posicionY");
        float posZ = PlayerPrefs.GetFloat("posicionZ");
        transform.position = new Vector3(posX, posY, posZ);
    }
}
