using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestauradorScript : MonoBehaviour
{
    private bool isPlayerInRange;

    public GameObject MostrarItemFotoFinal;

    Animator ranimatorController;
    void Start()
    {
        ranimatorController = this.GetComponent<Animator>();
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

            new WaitForSecondsRealtime(3.5f);
            MostrarItemFotoFinal.SetActive(true);

            ranimatorController.SetBool("aTrabajar", true);

            Debug.Log("Foto restaurada y mostrada");
        }
    }
}
