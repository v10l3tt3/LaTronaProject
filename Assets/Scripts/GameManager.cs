using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int pieza1 = 0;
    public static int pieza2 = 0;
    public static int pieza3 = 0;

    public static int trozoFoto = 0;


    public GameObject PipesHolder;
    public GameObject[] Pipes;

    [SerializeField]
    int totalPipes = 0;

    public static GameManager Instance { get; private set; }
    void Awake(){
       if(Instance == null ){
            Instance = this;
       }

    }
    void Start()
    {
        totalPipes = PipesHolder.transform.childCount;
        Pipes = new GameObject[totalPipes];
        for (int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    }

    
    void Update()
    {
        
    }
}
