using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiniMazon : MonoBehaviour
{

    Vector3 posicionInicial;

    GameObject player;
    //AudioSource _audioSource;

    //public float mazonSpeed = 5f;   


    //public Sprite spriteLimpio;
    //public Sprite spriteSucio;
    //public Sprite spriteMuySucio;

    //private int impactos = 0;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;

        player = GameObject.FindGameObjectWithTag("Player");
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = spriteLimpio; 

        //_audioSource = this.GetComponent<AudioSource>();
    }

    /*public void RecibirImpacto()
    {
        impactos++;

        if (impactos == 1)
        {
            spriteRenderer.sprite = spriteSucio;
        }
        else if (impactos >= 2)
        {
            spriteRenderer.sprite = spriteMuySucio;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Proyectil"))
        {
            RecibirImpacto();
            Destroy(col.gameObject); //Destruye el proyectil
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }*/
}
