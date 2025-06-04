using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitadFotoAparecer : MonoBehaviour
{
    public GameObject iconoMitad;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnTriggerEnter2D(Collider2D colC){
        if(colC.gameObject.tag == "Player"){

            //GameObject.Find("Item3-Foto-mal-mitad1de2")
            iconoMitad.SetActive(true);
            
            
            
        }
    }

}
