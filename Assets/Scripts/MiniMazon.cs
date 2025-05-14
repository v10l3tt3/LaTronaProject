using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMazon : MonoBehaviour
{

    public Sprite spriteLimpio;
    public Sprite spriteSucio;
    public Sprite spriteMuySucio;

    private int impactos = 0;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
       spriteRenderer.sprite = spriteLimpio; 
    }

    public void RecibirImpacto()
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Proyectil"))
        {
            RecibirImpacto();
            Destroy(collision.gameObject); //Destruye el proyectil
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
