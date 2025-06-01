using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
// Este script se encarga de activar la luz global al iniciar el juego

public class LuzVuelveScript : MonoBehaviour
{
    GameObject globalight;
    void Start()
    {
        globalight = GameObject.Find("GlobalLight2D");
        globalight.GetComponent<Light2D>().enabled = true;// Asegúrate de que el componente Light2D está activo
        globalight.GetComponent<Light2D>().intensity = 0.04f; // Ajusta la intensidad de la luz si es necesario
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            globalight.GetComponent<Light2D>().enabled = true; 
            globalight.GetComponent<Light2D>().intensity = 1f; // Vuelta a la intensidad normal
        }
    }
}
