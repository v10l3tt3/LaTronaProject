using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MiniFusibles : MonoBehaviour
{
    
    

    float [] switchesrotations = { 0, 180 };
    public float correctSwitchRotation; // Flip correcto para el fusible

    [SerializeField]
    bool isPlacedF = false;

    //fusibles
    GameObject fusible1;

    //luces correctas
    public GameObject tinyLight;

    GameManager gameManager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManagerObj").GetComponent<GameManager>();
    }

    void Start()
    {
        int rand = Random.Range(0, switchesrotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rand * 180); // Asignar una rotación aleatoria de 0 o 180 grados

        //para 1 sola solucion
        if (transform.eulerAngles.z == correctSwitchRotation)
        {
            isPlacedF = true;
        }else if (isPlacedF == true)
        {
            isPlacedF = false;
        }

        /*fusible1 = GameObject.Find("Plomillos-black-1");
        fusible1.GetComponent<SpriteRenderer>().flipY = false;
        fusible1.GetComponent<BoxCollider2D>().enabled = true;*/
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //this.GetComponent<SpriteRenderer>().flipY = true;
        
        Debug.Log("Click");

        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxFuseSwitch);
        
        //if ( FlipYTool== correctSwitch && isPlacedF == false){}

       
        transform.Rotate(new Vector3(0, 0, 180));
        
        //para 1 sola solucion
        if (transform.eulerAngles.z == correctSwitchRotation && isPlacedF == false)
        {
            isPlacedF = true;
            gameManager.correctSwitch();
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (isPlacedF == true)
        { isPlacedF = false; } 
    }
}
