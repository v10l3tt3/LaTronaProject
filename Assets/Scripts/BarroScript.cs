using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class BarroScript : MonoBehaviour
{
    GameObject player;
    //private Vector3 posicionInicial;

    public float velocidadBola = 5.0f;
    //private Rigidbody2D proyectilRb;
    
    //public float distanciaMaxima = 23f;
    float timeIs;
    float destructionTime = 5.0f;

    /*public void Inicializar(Vector3 origen, float velocidadDisparo)
    {
        posicionInicial = origen;
        velocidadBola = velocidadDisparo;
    }*/

    /*void Awake()
    {
        proyectilRb = GetComponent<Rigidbody2D>();
        posicionInicial = transform.position;
    }*/


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        timeIs = Time.time;

    }

    
    
    void Update()
    {
        //para el eje Y:
        transform.Translate(0, velocidadBola*Time.deltaTime, 0, Space.World);

        if (Time.time >= timeIs + destructionTime)
        {
            Destroy(this.gameObject, 0.1f);
        }


        // Mover la bola SOLO hacia arriba (eje Y)
        //transform.Translate(Vector3.up * velocidadBola * Time.deltaTime);

        // Verificar distancia
        //float distanciaRecorrida = Vector3.Distance(posicionInicial, transform.position);

        //float distanciaRecorrida = transform.position.y - player.transform.position.y;
        /*if (distanciaRecorrida >= distanciaMaxima)
        {
            Destroy(this.gameObject, 0.1f);
        }*/
    }

    void OnTriggerEnter2D(Collider2D colBS)
    {
        Debug.Log(colBS.gameObject.tag == "Mazon");

        if (colBS.gameObject.tag == "Mazon")
        {


            //Destroy(colBS.gameObject, 0.1f);
            GameManager.vidasMazon -= 1;
            Destroy(this.gameObject, 0.5f);
        
        }


        Debug.Log(colBS.gameObject.tag == "Policia");

        if (colBS.gameObject.tag == "Policia")
        {
            //poner FX audio daño policia
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.poliDolorOinkFX);

            //para que se queden quietos al morir
            Rigidbody2D rb = colBS.gameObject.GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        
            //animacion de muerte PROVISIONAL
            colBS.gameObject.GetComponent<Animator>().SetBool("ManchadoFatal", true);
            colBS.gameObject.GetComponent<Animator>().SetBool("ManchadoFatalOther", true);

            Destroy(colBS.gameObject, 2.6f);
            //GameManager.poliKills += 1;
            Destroy(this.gameObject, 0.5f);
        }

    }
}
//     void OnTriggerEnter2D(Collider2D other)
