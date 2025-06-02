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
        }
        else if (isPlacedF == true)
        {
            isPlacedF = false;
        }

        fb1 = GameObject.Find("Plomillos-black-1");
        fb2 = GameObject.Find("Plomillos-black-2");
        fb3 = GameObject.Find("Plomillos-black-3");
        fb4 = GameObject.Find("Plomillos-black-4");
        fb5 = GameObject.Find("Plomillos-black-5");
        fo1 = GameObject.Find("Plomillos-orange-1");
        fo2 = GameObject.Find("Plomillos-orange-2");

        /*light0 = GameObject.Find("Light2D0");
        light1 = GameObject.Find("Light2D1");
        light2 = GameObject.Find("Light2D2");
        light3 = GameObject.Find("Light2D3");
        light4 = GameObject.Find("Light2D4");
        light5 = GameObject.Find("Light2D5");
        light6 = GameObject.Find("Light2D6");*/



        fb1.GetComponent<BoxCollider2D>().enabled = true;
        fb2.GetComponent<BoxCollider2D>().enabled = true;
        fb3.GetComponent<BoxCollider2D>().enabled = true;
        fb4.GetComponent<BoxCollider2D>().enabled = true;
        fb5.GetComponent<BoxCollider2D>().enabled = true;
        fo1.GetComponent<BoxCollider2D>().enabled = true;
        fo2.GetComponent<BoxCollider2D>().enabled = true;

        /*light0.SetActive(false);
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
        light5.SetActive(false);
        light6.SetActive(false);*/
        

        
        //tinyLight.SetActive(false);
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
