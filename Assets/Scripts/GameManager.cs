using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int pieza1 = 0;
    public static int pieza2 = 0;
    public static int pieza3 = 0;

    public static int trozoFoto = 0;

    public static GameManager Instance { get; private set; }
    void Awake(){
       if(Instance == null ){
            Instance = this;
       }
        
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
