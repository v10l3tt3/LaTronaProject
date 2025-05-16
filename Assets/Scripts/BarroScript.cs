using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarroScript : MonoBehaviour
{
    private Vector3 posicionInicial;
    private float velocidad;
    private float distanciaMaxima = 7f;
    float timeIs;
    float destructionTime = 5.0f;

    public void Inicializar(Vector3 origen, float velocidadDisparo)
    {
        posicionInicial = origen;
        velocidad = velocidadDisparo;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.01f, 0, Space.World);

        if(Time.time >= timeIs+destructionTime){
            Destroy(this.gameObject);
        } 
        

        // Mover la bola SOLO hacia arriba (eje Y)
        transform.Translate(Vector3.up * velocidad * Time.deltaTime);

        // Verificar distancia
        float distanciaRecorrida = Vector3.Distance(posicionInicial, transform.position);
        if (distanciaRecorrida >= distanciaMaxima)
        {
            Destroy(gameObject);
        }
    }
}
