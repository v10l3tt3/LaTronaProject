using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniTuberias : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };
    public float correctRotation;
    [SerializeField]
    bool isPlaced = false;


    //int PossibleRots = 1;

    GameManager gameManager;
    

    void Awake()
    {
        gameManager = GameObject.Find("GameManagerObj").GetComponent<GameManager>();
        
    }

    private void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, 90);
        
        
        GetComponent<BoxCollider2D>().enabled = true;



        //para 1 sola solucion
        if (transform.eulerAngles.z == correctRotation)
        {
            isPlaced = true;
            gameManager.correctMove();
            

        }
        else if (isPlaced == true)
        {
            isPlaced = false;
        }



        //para +1 solucion
        //PossibleRots = rotations.Length;
        /*if(PossibleRots > 1){
            if(transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1]){
                isPlaced = true;
            }else{
            isPlaced = false;
            }
        }*/

    }


    void Update()
    {
        //aprox 1
        /*if (Input.GetMouseButtonDown(0))
        {transform.Rotate(0, 0, -90);
            Debug.Log("Click");}*/
    }
    private void OnMouseDown()
    {

        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxPipesClick);

        transform.Rotate(new Vector3(0, 0, 90));
        Debug.Log("Click");

        //para 1 sola solucion
        if (transform.eulerAngles.z == correctRotation && isPlaced == false)
        {
            isPlaced = true;
            gameManager.correctMove();
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (isPlaced == true)
        {
            isPlaced = false;
        }

        //para +1 solucion
        /*if(PossibleRots > 1){
            if(transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] && isPlaced == false){
                isPlaced = true;
            }else if(isPlaced == true){
                isPlaced = false;
            }
        }*/

        //PREFERENCIA POR SOLO 1 SOLUCION
    }

    

}

