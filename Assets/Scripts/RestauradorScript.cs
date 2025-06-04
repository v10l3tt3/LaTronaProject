using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestauradorScript : MonoBehaviour
{
    private bool isPlayerInRange;

    public GameObject MostrarItemFotoFinal;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;

            new WaitForSecondsRealtime(2.5f);
            MostrarItemFotoFinal.SetActive(true);
            Debug.Log("Foto restaurada y mostrada");
        }
    }
}
