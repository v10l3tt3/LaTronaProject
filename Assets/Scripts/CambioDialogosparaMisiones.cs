using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDialogosparaMisiones : MonoBehaviour
{
    //prueba npcs
    //GameObject vDIA;
    //GameObject vDIA2;

    // prueba mision bool
    // bool mision = false;

    GameObject senyoraIntro;
    GameObject senyoratoPipe;
    GameObject senyoratoRestaurarFoto;
    GameObject senyoraEnd;

    GameObject pagesIntrodaAgua;
    GameObject pagestoMazon;
    GameObject pagesdaPipes;

    GameObject vIntroAgua;
    GameObject vdaHoja;

    //public bool tePidieronAgua = false;
    //public bool agua = false;



    void Start()
    {
        /*vDIA = GameObject.Find("VoluntariDIA");
        vDIA2 = GameObject.Find("VoluntariDIA2");
        vDIA2.SetActive(false);*/

        senyoraIntro = GameObject.Find("Senyora-Intro");
        senyoratoPipe = GameObject.Find("Senyora-PostFuse-to-Pipe");
        senyoratoPipe.SetActive(false);
        senyoratoRestaurarFoto = GameObject.Find("Senyora-postFoto-toRestaurar");
        senyoratoRestaurarFoto.SetActive(false);
        senyoraEnd = GameObject.Find("Senyora-end");
        senyoraEnd.SetActive(false);

        pagesIntrodaAgua = GameObject.Find("Pages-Intro-daAgua");
        pagestoMazon = GameObject.Find("Pages-toMazon");
        pagestoMazon.SetActive(false);
        pagesdaPipes = GameObject.Find("Pages-postMazon-daPipes");
        pagesdaPipes.SetActive(false);

        vIntroAgua = GameObject.Find("Voluntari-IntroAgua");
        vdaHoja = GameObject.Find("Voluntari-daHoja");
        vdaHoja.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        //revisar...
        if (GameManager.Instance.tePidieronAgua == true && GameManager.Instance.agua == false)
        {
            vIntroAgua.SetActive(true);

        }

        if (GameManager.Instance.tePidieronAgua == true && GameManager.Instance.agua == true)
        {
            // Si el agua ha sido limpiada, desactiva la señora de la restauración de la foto
            vIntroAgua.SetActive(false);
            vdaHoja.SetActive(true);
            GameManager.Instance.hoja = true;
        }

        if (GameManager.Instance.mFusColocado == true)
        {
            // Si ls fusibles colocados, desactiva la señora de la introducción
            senyoraIntro.SetActive(false);
            senyoratoPipe.SetActive(true);

            pagesIntrodaAgua.SetActive(false);
            pagestoMazon.SetActive(true);
        }

        if (GameManager.vidasMazon <= 2)
        {
            // Si Mazon ha perdido todas sus vidas, desactiva la señora de la restauración de la foto
            pagestoMazon.SetActive(false);
            pagesdaPipes.SetActive(true);
            GameManager.Instance.tuberiasnuevas = true;
        }

        if (GameManager.Instance.tuberiasnuevas == true && GameManager.Instance.mTubArreglado == true && GameManager.Instance.fotocompleta == true)
        {
            // Si las tuberías nuevas han sido colocadas, desactiva la señora de las tuberías
            senyoratoPipe.SetActive(false);
            senyoratoRestaurarFoto.SetActive(true);
        }

        if (GameManager.Instance.fotocompleta == true)
        {
            // Si la foto ha sido restaurada, desactiva la señora de las tuberías
            senyoratoPipe.SetActive(false);
            senyoratoRestaurarFoto.SetActive(true);
        }

        if (GameManager.Instance.fotoRestaurada == true)
        {
            // Si la foto ha sido restaurada, desactiva la señora de la restauración de la foto
            senyoratoRestaurarFoto.SetActive(false);
            senyoraEnd.SetActive(true);
        }


        /*if (Input.GetKeyDown(KeyCode.N))
        {
            mision = true;
            // Cambia entre los dos diálogos al pulsar la tecla N
            if (mision == false)
            {
                vDIA.SetActive(true);
                vDIA2.SetActive(false);
                mision = true;
            }
            else
            {
                vDIA.SetActive(false);
                vDIA2.SetActive(true);
                mision = false;
            }
        }*/
    }
}
