using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    public static int pieza1 = 0;
    public static int pieza2 = 0;


    public static int trozoFoto = 0;


    //TUB
    GameObject PipesHolder;
    GameObject[] Pipes;

    //FUSIBLES
    GameObject FusesHolder;
    GameObject[] Fuses;



    public bool mTubArreglado = false;
    public bool mFusColocado = false;

    [SerializeField]
    int totalPipes = 0;

    [SerializeField]
    int correctedPipes = 0;

    [SerializeField]
    int totalFuses = 0;

    [SerializeField]
    int correctedFuses = 0;

    
    
    GameObject fb1;
    GameObject fb2;
    GameObject fb3;
    GameObject fb4;
    GameObject fb5;
    GameObject fo1;
    GameObject fo2;

    
    GameObject light0;
    GameObject light1;
    GameObject light2;
    GameObject light3;
    GameObject light4;
    GameObject light5;
    GameObject light6;

    GameObject tinyLight;


    
    Component fb1COL;
    Component fb2COL;



    //public static int vidasMazon = 4;
    //public float health, maxHealth;
    GameObject vidasMazonText;




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

        tinyLight = GameObject.FindGameObjectWithTag("OnTinyLight");
        //tinyLight = GameObject.FindWithTag("OnTinyLight");

        //tinyLight.GetComponentInChildren<Light2D>().enabled = false; // Desactivar luz al inicio

        tinyLight.GetComponentInChildren<Light2D>().enabled = false; // Desactivar luz al inicio

        //tinyLight.SetActive(false);



        //health = gameObject.GetComponent<MiniMazon>().health;
        //maxHealth = gameObject.GetComponent<MiniMazon>().maxHealth;

        //vidasMazonText = GameObject.Find("vidasMazonText");


        fb1 = GameObject.Find("Plomillos-black-1");
        fb2 = GameObject.Find("Plomillos-black-2");
        fb3 = GameObject.Find("Plomillos-black-3");
        fb4 = GameObject.Find("Plomillos-black-4");
        fb5 = GameObject.Find("Plomillos-black-5");
        fo1 = GameObject.Find("Plomillos-orange-1");
        fo2 = GameObject.Find("Plomillos-orange-2");

        light0 = GameObject.Find("Light2D0");
        light1 = GameObject.Find("Light2D1");
        light2 = GameObject.Find("Light2D2");
        light3 = GameObject.Find("Light2D3");
        light4 = GameObject.Find("Light2D4");
        light5 = GameObject.Find("Light2D5");
        light6 = GameObject.Find("Light2D6");

        light0.SetActive(false);
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
        light5.SetActive(false);
        light6.SetActive(false);
        
        /*fb1COL = fb1.GetComponent<BoxCollider2D>();
        fb2COL = fb2.GetComponent<BoxCollider2D>();

        ((BoxCollider2D)fb1COL).enabled = true;
        ((BoxCollider2D)fb2COL).enabled = true;*/



    }


    void Update()
    {
        //Debug.Log("Vidas Mazon: " + health + " / " + maxHealth);

        //vidasMazonText.GetComponent<TMPro.TextMeshProUGUI>().text = health.ToString() + " / " + maxHealth.ToString();


        /*if (GameManager.vidasMazon == 3)
        {
            //fx audio 
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.1DolorMazonFX);
            gameObject.GetComponent<Animator>().SetBool("HIT1", true);
        }
        else if (GameManager.vidasMazon == 2)
        {
            //fx audio 
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.2DolorMazonFX);
            gameObject.GetComponent<Animator>().SetBool("HIT2", true);
        }
        else if (GameManager.vidasMazon == 1){
            //fx audio 
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.3DolorMazonFX);
            gameObject.GetComponent<Animator>().SetBool("HIT3", true);
        }*/
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


        /*if (fb1.GetComponent<MiniFusibles>().isPlacedF == true)
        {
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxMovBienTub);
            correctedFuses += 1;
            fb1.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("Plomillo colocado: " + correctedFuses + " de " + totalFuses);
            light0.SetActive(true);  
        }

        if (fb2.GetComponent<MiniFusibles>().isPlacedF == true)
        {
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxMovBienTub);
            correctedFuses += 1;
            fb2.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("Plomillo colocado: " + correctedFuses + " de " + totalFuses);
            light2.SetActive(true);
        }

        //correctedFuses += 1;

        correctedFuses += 1;
        Debug.Log("Plomillo colocado: " + correctedFuses + " de " + totalFuses);
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxMovBienTub);

        // Activar luz REVISAR
        //tinyLight.GetComponentInChildren<Light2D>(true).enabled = true; 
        if (correctedFuses == totalFuses)
        {
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxLogroFuse);
            Debug.Log("Plomillos colocados");
            mFusColocado = true;
        }*/
    }
}

