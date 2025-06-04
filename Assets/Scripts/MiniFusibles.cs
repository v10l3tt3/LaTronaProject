using System.Collections;
using System.Collections.Generic;
using UnityEditor;
//using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MiniFusibles : MonoBehaviour
{
    
    

    float [] switchesrotations = { 0, 180 };
    public float correctSwitchRotation; // Flip correcto para el fusible

    [SerializeField]
    public bool isPlacedF = false;

    //fusibles
    [SerializeField]
    GameObject fb1;
    GameObject fb2;
    GameObject fb3;
    GameObject fb4;
    GameObject fb5;
    GameObject fo1;
    GameObject fo2;

    

    [SerializeField]
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
        fb1 = GameObject.Find("Plomillos-black-1");
        fb1.transform.eulerAngles = new Vector3(0, 0, 0);

        fb2 = GameObject.Find("Plomillos-black-2");
        fb2.transform.eulerAngles = new Vector3(0, 0, 180);

        fb3 = GameObject.Find("Plomillos-black-3");
        fb3.transform.eulerAngles = new Vector3(0, 0, 0);

        fb4 = GameObject.Find("Plomillos-black-4");
        fb4.transform.eulerAngles = new Vector3(0, 0, 180);

        fb5 = GameObject.Find("Plomillos-black-5");
        fb5.transform.eulerAngles = new Vector3(0, 0, 180);

        fo1 = GameObject.Find("Plomillos-orange-1");
        fo1.transform.eulerAngles = new Vector3(0, 0, 0);

        fo2 = GameObject.Find("Plomillos-orange-2");
        fo2.transform.eulerAngles = new Vector3(0, 0, 180);

       

        //int rand = Random.Range(0, switchesrotations.Length);
        //transform.eulerAngles = new Vector3(0, 0, 0); // Asignar una rotación aleatoria de 0 o 180 grados


        //para 1 sola solucion
        if (transform.eulerAngles.z == correctSwitchRotation)
        {
            isPlacedF = true;
        }
        else if (isPlacedF == true)
        {
            isPlacedF = false;
        }

        

        //GetComponent<BoxCollider2D>().enabled = true;

        //fb1.transform.eulerAngles = new Vector3(0, 0, rand * 180); 

        /*fb1.GetComponent<BoxCollider2D>().enabled = true;
        fb2.GetComponent<BoxCollider2D>().enabled = true;

        fb3.GetComponent<BoxCollider2D>().enabled = true;
        fb4.GetComponent<BoxCollider2D>().enabled = true;
        fb5.GetComponent<BoxCollider2D>().enabled = true;
        fo1.GetComponent<BoxCollider2D>().enabled = true;
        fo2.GetComponent<BoxCollider2D>().enabled = true;*/

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
        /*if (isPlacedF == false)
        {
            fb3.GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            fb3.GetComponent<BoxCollider2D>().enabled = false;
        }*/

        if (GameManager.Instance.mFusColocado == true)
        {
            GameObject.Find("GlobalLight").GetComponent<Light2D>().intensity = 1f; // Aumentar intensidad de la luz global
        }
    }

    private void OnMouseDown()
    {
        this.GetComponent<SpriteRenderer>().flipY = true;
        //Debug.Log("Click");

        if (this.GetComponent<SpriteRenderer>().flipY == true)
        {
            isPlacedF = true;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Light2D>().enabled = true;
            gameManager.correctSwitch();
        }
            

        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxFuseSwitch);
        /*transform.Rotate(new Vector3(0, 0, 180));

        //para 1 sola solucion
        if (transform.eulerAngles.z == correctSwitchRotation && isPlacedF == false)
        {
            GetComponent<BoxCollider2D>().enabled = false;

            isPlacedF = true;

            gameManager.correctSwitch();

        }
        else if (isPlacedF == true)
        {
            isPlacedF = false;
        }*/
       
        

    }
}
