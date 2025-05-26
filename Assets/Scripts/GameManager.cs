using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int pieza1 = 0;
    public static int pieza2 = 0;


    public static int trozoFoto = 0;


    public GameObject PipesHolder;
    public GameObject[] Pipes;

    public GameObject FusesHolder;
    public GameObject[] Fuses;

    [SerializeField]
    int totalPipes = 0;
    
    [SerializeField]
    int totalFuses = 0;

    //public static int vidasMazon = 4;
    float health, maxHealth;
    GameObject vidasMazonText;




    public static GameManager Instance { get; private set; }
    void Awake(){
       if(Instance == null ){
            Instance = this;
       }

    }
    void Start()
    {
        //para MiniTuberias
        totalPipes = PipesHolder.transform.childCount;
        Pipes = new GameObject[totalPipes];
        for (int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }

        //para MiniFusibles
        totalFuses = FusesHolder.transform.childCount;
        Fuses = new GameObject[totalFuses];
        for (int i = 0; i < Fuses.Length; i++)
        {
            Fuses[i] = FusesHolder.transform.GetChild(i).gameObject;
        }

        health = gameObject.GetComponent<MiniMazon>().health;
        maxHealth = gameObject.GetComponent<MiniMazon>().maxHealth;

        vidasMazonText = GameObject.Find("vidasMazonText");
    }


    void Update()
    {
        Debug.Log("Vidas Mazon: " + health + " / " + maxHealth);

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
        else if (GameManager.vidasMazon == 1)
        {
            //fx audio 
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.3DolorMazonFX);
            gameObject.GetComponent<Animator>().SetBool("HIT3", true);
        }*/
    }
}

