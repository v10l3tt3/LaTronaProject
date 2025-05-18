using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class BarroScript : MonoBehaviour
{
    GameObject player;
    private Vector3 posicionInicial;
    private float velocidadBola;
    private float distanciaMaxima = 7f;
    float timeIs;
    float destructionTime = 5.0f;

    public void Inicializar(Vector3 origen, float velocidadDisparo)
    {
        posicionInicial = origen;
        velocidadBola = velocidadDisparo;
    }


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        timeIs = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.01f, 0, Space.World);

        if (Time.time >= timeIs + destructionTime)
        {
            Destroy(this.gameObject, 0.1f);
        }


        // Mover la bola SOLO hacia arriba (eje Y)
        transform.Translate(Vector3.up * velocidadBola * Time.deltaTime);

        // Verificar distancia
        float distanciaRecorrida = Vector3.Distance(posicionInicial, transform.position);
        if (distanciaRecorrida >= distanciaMaxima)
        {
            Destroy(this.gameObject, 0.1f);
        }
    }

    void OnTriggerEnter2D(Collider2D colBS)
    {
        Debug.Log(colBS.gameObject.tag == "Mazon");

        if (colBS.gameObject.tag == "Mazon")
        {
            // Aquí puedes agregar el código para aplicar daño al jugador
            // Por ejemplo: other.GetComponent<PlayerHealth>().TakeDamage(damageAmount);

            //poner FX audio daño Mazon
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.mazonDolorFX);

            Destroy(colBS.gameObject, 1.1f);
            GameManager.vidasMazon -= 1;

            colBS.gameObject.GetComponent<Animator>().SetBool("HIT1", true);

            if (GameManager.vidasMazon == 2)
            {
                Destroy(colBS.gameObject, 1.1f);
                colBS.gameObject.GetComponent<Animator>().SetBool("HIT2", true);
            
            }
            else if (GameManager.vidasMazon == 1)
            {
                Destroy(colBS.gameObject, 1.1f);
                colBS.gameObject.GetComponent<Animator>().SetBool("HIT3", true);
            }
        
        }


        Debug.Log(colBS.gameObject.tag == "Policia");

        if (colBS.gameObject.tag == "Policia")
        {
        //poner FX audio daño policia
        //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.mazonDolorFX);

        //animacion de muerte
        //colBS.gameObject.GetComponent<Animator>().SetBool("GetDown", true);

        //para que se queden quietos al morir
        Rigidbody2D rb = colBS.gameObject.GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        Destroy(colBS.gameObject, 1.1f);
        //GameManager.poliKills += 1;
        Destroy(this.gameObject, 3.1f);
        }

    }
}
//     void OnTriggerEnter2D(Collider2D other) 
