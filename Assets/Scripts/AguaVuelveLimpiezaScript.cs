using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguaVuelveLimpiezaScript : MonoBehaviour
{
    GameObject mTuberias;
    GameObject CasaSucia;
    GameObject CasaLimpia;

    GameObject IndicaPostTub;

    bool puedeTaparAgujero = false;

    GameObject ItemSemiPolaroid;
    void Start()
    {
        mTuberias = GameObject.Find("trigger-col-m.tub");
        mTuberias.SetActive(true);

        CasaLimpia = GameObject.FindWithTag("CasaLimpia");
        CasaSucia = GameObject.FindWithTag("CasaSucia");
        CasaSucia.SetActive(true);
        CasaLimpia.SetActive(false);

        IndicaPostTub = GameObject.Find("CanvasIndicaciones");
        IndicaPostTub.SetActive(false);

        ItemSemiPolaroid = GameObject.Find("Item-collect-polaroid");
        ItemSemiPolaroid.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (GameManager.Instance.mTubArreglado == true)
        {
            // Si el agua ha sido limpiada, desactiva las tuberías
            Debug.Log("Agua limpia, desactivando tuberías");

            // Desactiva el boquete de las tuberías  
            mTuberias.SetActive(false);

            // Activa la casa limpia
            CasaSucia.SetActive(false);
            CasaLimpia.SetActive(true);
        }*/

        /*if (GameManager.Instance.mTubArreglado == false)
        {
            // Si el agua no ha sido limpiada, activa las tuberías
            Debug.Log("Agua sucia, activando tuberías");

            // Activa el boquete de las tuberías
            mTuberias.SetActive(true);

            // Desactiva la casa limpia
            CasaLimpia.SetActive(true);
            CasaSucia.SetActive(false);
        }*/

        if (GameManager.Instance.mTubArreglado == true)
        {
            //Activa casa limpia

            CasaLimpia.SetActive(true);
            CasaSucia.SetActive(false);

            Debug.Log("Prem (Espai) per tapar l'esvoranc de les canonades");
            IndicaPostTub.SetActive(true);

            puedeTaparAgujero = true;

        }
        else if (puedeTaparAgujero = true && Input.GetKeyDown(KeyCode.Space))
        {

            new WaitForSecondsRealtime(2.5f);
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxMovBienTub);
            mTuberias.SetActive(false);
            IndicaPostTub.SetActive(false);
            
            //APARECE ITEM POLAROID SEMI
            ItemSemiPolaroid.SetActive(true);
        }
    }
}
