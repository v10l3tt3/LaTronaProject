using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MiniFusibles : MonoBehaviour
{
    /*float[] rotations = { 0, 180 };
    public float correctRotation;*/

    bool [] switches = { true, false};
    public float correctSwitch; // Flip correcto para el fusible

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
        /*int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, 0);

        //para 1 sola solucion
        if (transform.eulerAngles.z == correctRotation)
        {
            isPlacedF = true;
        }*/

        fusible1 = GameObject.Find("Plomillos-black-1");
        fusible1.GetComponent<SpriteRenderer>().flipY = false;
        fusible1.GetComponent<BoxCollider2D>().enabled = true;

        
    }

    void Update()
    {
        // No hay actualizaciones necesarias en este caso
    }

    private void OnMouseDown()
    {
        this.GetComponent<SpriteRenderer>().flipY = true;
        
        Debug.Log("Click");

        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxFuseSwitch);
        
        //if ( FlipYTool== correctSwitch && isPlacedF == false){}

        /*METODO DE TUBERIAS ADAPTADO, NO FUNCIONA
        transform.Rotate(new Vector3(0, 0, 180));
        //para 1 sola solucion
        if (transform.eulerAngles.z == correctRotation && isPlacedF == false)
        {
            isPlaced = true;
            // Activar luz REVISAR
            var light2D = tinyLight.GetComponentInChildren<UnityEngine.Rendering.Universal.Light2D>();
            if (light2D != null)
            {
                light2D.enabled = true;
            }
        }
        else if (isPlacedF == true)
        { isPlaced = false; }*/
    }
}
