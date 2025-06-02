using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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



        //health = gameObject.GetComponent<MiniMazon>().health;
        //maxHealth = gameObject.GetComponent<MiniMazon>().maxHealth;

        //vidasMazonText = GameObject.Find("vidasMazonText");
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
        correctedFuses += 1;
        Debug.Log("Plomillo colocado: " + correctedFuses + " de " + totalFuses);
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxMovBienTub);
        
        if (correctedFuses == totalFuses)
        {
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxLogroFuse);
            Debug.Log("Plomillos colocados");
            mFusColocado = true;
        }
    }
}

