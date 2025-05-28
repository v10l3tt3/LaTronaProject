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

    //CONTRA MOVPERSO
    //float movTeclas;

    //CONTRA MOVPERSO
    public float velocidadM = 1f;
    //CONTRA MOVPERSO
    public float multiplicadorM = 5f;

    //CONTRA MOVPERSO
    //private Vector2 moveInput;

    //PATROL AUTO
    public GameObject PuntoA;
    public GameObject PuntoB;

    private Transform currentPoint;

    private Rigidbody2D mRb;
    private Animator animatorController;

    [SerializeField] public float health, maxHealth = 3f;


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

        currentPoint = PuntoA.transform;
        //animatorController.SetBool("WalkM", true);

        health = maxHealth;
    }

    void FixedUpdate()
    {
        //contramovperso mRb.MovePosition(mRb.position + moveInput * velocidadM * Time.fixedDeltaTime);  
    }

    void Update()
    {
        float miDeltaTime = Time.deltaTime;

        health = GameManager.Instance.health;

        /*transform.Translate(
            movTeclas *  (Time.deltaTime * -multiplicadorM),0,0);

        //Animacion IDLE TO WALKING 
        movTeclas = Input.GetAxis("Horizontal");
        if (movTeclas != 0)
        {animatorController.SetBool("WalkM", true)} else {animatorController.SetBool("WalkM", false);}*/

        //PATROL AUTO
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == PuntoB.transform)
        {
            mRb.velocity = new Vector2(velocidadM, 0f);
        }
        else
        {
            mRb.velocity = new Vector2(-velocidadM, 0f);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 1.5f == PuntoB.transform)
        {
            currentPoint = PuntoA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 1.5f == PuntoA.transform)
        {
            currentPoint = PuntoB.transform;
        }

    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount; //3 -> 2 -> 1 

        if (health <= 2)
        {
            //fx audio
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.mazonDolor1FX);
            gameObject.GetComponent<Animator>().SetBool("HIT1", true);
        }
        else if (health <= 1)
        {
            //fx audio
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.mazonDolor2FX);
            gameObject.GetComponent<Animator>().SetBool("HIT2", true);
        }
        else if (health <= 0)
        {
            //fx audio
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.mazonDolor3FX);

            Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        
            gameObject.GetComponent<Animator>().SetBool("HIT3", true);
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
