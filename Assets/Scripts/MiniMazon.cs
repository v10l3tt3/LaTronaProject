using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiniMazon : MonoBehaviour
{

    Vector3 posicionInicial;

    GameObject player;
    //AudioSource _audioSource;

    //public float mazonSpeed = 5f;   


    //public Sprite spriteLimpio;
    //public Sprite spriteSucio;
    //public Sprite spriteMuySucio;

    //private int impactos = 0;
    private SpriteRenderer spriteRenderer;

    float movTeclas;

    public float velocidadM = 5f;
    public float multiplicadorM = 5f;

    private Animator animatorController;
    private Rigidbody2D mRb;
    private Vector2 moveInput;
    

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;

        player = GameObject.FindGameObjectWithTag("Player");
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = spriteLimpio; 

        //_audioSource = this.GetComponent<AudioSource>();

        mRb = this.GetComponent<Rigidbody2D>();
        animatorController = this.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        mRb.MovePosition(mRb.position + moveInput * velocidadM * Time.fixedDeltaTime);  
    }

    void Update()
    {
        float miDeltaTime = Time.deltaTime;

        transform.Translate(
             movTeclas *  (Time.deltaTime * -multiplicadorM),
             0,
             0
        );

        //Animacion IDLE TO WALKING 
        movTeclas = Input.GetAxis("Horizontal");
        if (movTeclas != 0)
        {
            animatorController.SetBool("WalkM", true);
        }
        else
        {
            animatorController.SetBool("WalkM", false);
        }
    } 

    /*public void RecibirImpacto()
    {
        impactos++;

        if (impactos == 1)
        {
            spriteRenderer.sprite = spriteSucio;
        }
        else if (impactos >= 2)
        {
            spriteRenderer.sprite = spriteMuySucio;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Proyectil"))
        {
            RecibirImpacto();
            Destroy(col.gameObject); //Destruye el proyectil
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }*/
}
