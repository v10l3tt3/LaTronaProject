using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    public static int pieza1 = 0;
    public static int pieza2 = 0;

    public GameObject item1Hoja;
    public GameObject item2Tuberias;
    public GameObject item3FotoMitad;
    public GameObject item3FotoCompleta;
    public GameObject item3FotoRestaurada;


    public static int trozoFoto = 0;


    //TUB
    GameObject PipesHolder;
    GameObject[] Pipes;

    //FUSIBLES
    GameObject FusesHolder;
    GameObject[] Fuses;



    public bool mTubArreglado = false;
    public bool mFusColocado = false;

    public int fotomitades = 0;
    public bool fotocompleta = false;

    public bool fotoRestaurada = false;

    [SerializeField]
    int totalPipes = 0;

    [SerializeField]
    int correctedPipes = 0;

    [SerializeField]
    public int totalFuses = 0;

    [SerializeField]
    public int correctedFuses = 0;



    GameObject tinyLight;


    
    Component fb1COL;
    Component fb2COL;



    public static int vidasMazon = 4;
    //public static int health;
    /// <summary>
    //public static int maxHealth = 4;
    /// </summary>
    GameObject vidasMazonText;

    public static int contadorInteracciones = 0;

    public bool tePidieronAgua = false;
    public bool agua = false;

    public bool hoja = false;

    GameObject hojaPista;
    public bool tuberiasnuevas = false;


    public static GameManager Instance { get; private set; }
    void Awake()
    {
        //Si existe otro objeto de este tipo, destruyelo
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Start()
    {
        //para MiniTuberias
        PipesHolder = GameObject.FindWithTag("TUB");
        Pipes = GameObject.FindGameObjectsWithTag("PipesSingle");

        //para MiniFusibles
        FusesHolder = GameObject.FindWithTag("FUSIBLES");
        Fuses = GameObject.FindGameObjectsWithTag("FusesSingle");


        /*totalPipes = PipesHolder.transform.childCount;
        Pipes = new GameObject[totalPipes];
        for (int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }*/
        totalPipes = 34; // Total de tuberías que hay que arreglar
        totalFuses = 7; // Total de fusibles que hay que arreglar

        // //vidasMazonText = GameObject.Find("vidasMazonText");

        /*fb1COL = fb1.GetComponent<BoxCollider2D>();
        fb2COL = fb2.GetComponent<BoxCollider2D>();

        ((BoxCollider2D)fb1COL).enabled = true;
        ((BoxCollider2D)fb2COL).enabled = true;*/

        //fo2.GetComponent<Light2D>().enabled = false; 

        //ITEMS
        /*item1Hoja = GameObject.Find("Item1-hojas");
        item1Hoja.SetActive(false);

        hojaPista = GameObject.Find("HojaPista-Item1");
        hojaPista.SetActive(false);

        item2Tuberias = GameObject.Find("Item2-tuberias");
        item2Tuberias.SetActive(false);

        item3FotoMitad = GameObject.Find("Item3-Foto-mal-mitad1de2");
        item3FotoMitad.SetActive(false);

        item3FotoCompleta = GameObject.Find("Item3-Foto-mal-mitad2de2");
        item3FotoCompleta.SetActive(false);

        item3FotoRestaurada = GameObject.Find("Item3-Foto-restaurada");
        item3FotoRestaurada.SetActive(false);*/

        //GameObject.Find("HojaPista-Item1").SetActive(false);
        

        GameObject.Find("CanvasMuestreoTuberias").SetActive(true);
        GameObject.Find("---EntramadoWaterTubs---").SetActive(false);

    }


    void Update()
    {
        //Debug.Log("Vidas Mazon: " + health + " / " + maxHealth);
        Debug.Log(+vidasMazon + " / " + 4);

        //vidasMazonText.GetComponent<TMPro.TextMeshProUGUI>().text = health.ToString() + " / " + maxHealth.ToString();

        if (fotomitades == 1)
        {
            Destroy(GameObject.Find("Item-collect-semi"));
            item3FotoMitad.SetActive(true);
        }

        if (fotomitades == 2)
        {
            // Si se han recogido las dos mitades de la foto, activa la foto completa

            fotocompleta = true;
            item3FotoCompleta.SetActive(true);
            Debug.Log("Foto completa activada");
        }

        if (hoja == true)
        {
            // Si se ha recogido la hoja, activa el item de la hoja
            item1Hoja.SetActive(true);
            hojaPista.SetActive(true);
            Debug.Log("Hoja activada");
        }

        if (tuberiasnuevas == true)
        {
            // Si se han recogido las tuberías nuevas, activa el item de las tuberías
            item2Tuberias.SetActive(true);
            GameObject.Find("CanvasMuestreoTuberias").SetActive(false);
            GameObject.Find("---EntramadoWaterTubs---").SetActive(true);
            Debug.Log("Tuberías nuevas activadas");

        }
        
        
    }

    public void correctMove()
    {
        correctedPipes += 1;
        Debug.Log("Tubería arreglada: " + correctedPipes + " de " + totalPipes);
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxMovBienTub);


        if (correctedPipes == totalPipes)
        {
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxLogroTub);
            Debug.Log("Tuberías arregladas");
            mTubArreglado = true;
        }
    }

    public void correctSwitch()
    {
        correctedFuses += 1;
        Debug.Log("Plomillo colocado: " + correctedFuses + " de " + totalFuses);
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxMovBienTub);



        // Activar luz REVISAR
        //tinyLight.GetComponentInChildren<Light2D>(true).enabled = true; 
        if (correctedFuses == totalFuses)
        {

            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxLogroFuse);
            Debug.Log("Plomillos colocados");
            // Activar luz de la escena
            GameObject.Find("FGlobal-light2D").GetComponent<Light2D>().intensity = 1f; // Aumentar intensidad de la luz global
            mFusColocado = true;   
        }
    }
}

