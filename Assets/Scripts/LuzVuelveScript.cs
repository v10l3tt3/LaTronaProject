using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
// Este script se encarga de activar la luz global al iniciar el juego

public class LuzVuelveScript : MonoBehaviour
{
    GameObject globalight;
    public GameObject ItemSemiPolaroid;
   
    void Start()
    {
        /*globalight = GameObject.Find("GlobalLight2D");
        globalight.GetComponent<Light2D>().enabled = true;// Asegúrate de que el componente Light2D está activo
        globalight.GetComponent<Light2D>().intensity = 0.04f;*/ // Ajusta la intensidad de la luz si es necesario

        //ItemSemiPolaroid = GameObject.Find("Item-collect-semi");
        //ItemSemiPolaroid.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.mFusColocado == true)
        {
            //globalight.GetComponent<Light2D>().enabled = true;
            GameObject.Find("GlobalLight2D").GetComponent<Light2D>().intensity = 1f; // Vuelta a la intensidad normal
            
            //APARECE ITEM POLAROID SEMI
            ItemSemiPolaroid.SetActive(true);
        }
    }
}
