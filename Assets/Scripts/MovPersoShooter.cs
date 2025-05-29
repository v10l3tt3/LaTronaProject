using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using TMPro;
using System;


public class MovPersoShooter : MonoBehaviour
{

    public float velocidad = 5f;
    public float multiplicador = 5f;
    float movTeclas;
    private Animator animatorController;
    private Rigidbody2D playerRb;
    private Vector2 moveInput;

    public bool miraDerecha = true;


    //ACTIVAR INDICACIONES DIALOGO 
    /*[SerializeField] private GameObject dialogueMark;
    [SerializeField] private GameObject dialogoPanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField, TextArea(4, 6)] private string[] dialogueLines;

    public float typingTime = 0.05f;

    private bool isPlayerInRange;
    private bool didDialogueStart;
    private int lineIndex;*/
    void Start()
    {
        playerRb = this.GetComponent<Rigidbody2D>();

        animatorController = this.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * velocidad * Time.fixedDeltaTime);

        //MOVIMIENTO
        float movTeclas = Input.GetAxis("Horizontal");

        //float moveX = Input.GetAxisRaw("Horizontal");

        transform.Translate(
             movTeclas * (Time.deltaTime * multiplicador),
             0,
             0
        );

        //Animacion IDLE TO WALKING
        if (movTeclas != 0)
        {
            animatorController.SetBool("WalkH", true);
        }
        else
        {
            animatorController.SetBool("WalkH", false);
        }

        //Aprox2 de FLIP(ambas direcciones)
        if (movTeclas < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            miraDerecha = false;
        }
        else if (movTeclas > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            miraDerecha = true;
        }
    }

    void Update()
    {
        float miDeltaTime = Time.deltaTime;
    }
        //Acabar si da tiempo: typing apprering indiccations
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {

            StartDialogue();


        }
    }

    public void StartDialogue()
    {
        didDialogueStart = true;
        dialogoPanel.SetActive(true);
        //dialogueMark.SetActive(false);
        lineIndex = 0;
        //Time.timeScale = 0f; // Pausa todo el juego
        StartCoroutine(ShowDialogueLine());
    }

    private IEnumerator ShowDialogueLine()
    {
        dialogueText.text = string.Empty;
        foreach(char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSecondsRealtime(typingTime);
        }
    }*/

}
