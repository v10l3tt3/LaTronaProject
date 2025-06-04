using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOTOrestauradaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject fotoAntes;
    public GameObject fotoDespues;
    void Update()
    {

    }
    
    void OnTriggerEnter2D(Collider2D colC){
        if(colC.gameObject.tag == "Player"){

            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxPhotoCompleted);
            Destroy(this.gameObject, 0.1f);
            GameManager.Instance.fotoRestaurada = true;


            fotoAntes.SetActive(false);
            fotoDespues.SetActive(true);
            
            
        }
    }
}
