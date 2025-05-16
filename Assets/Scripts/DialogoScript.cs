using System.Collections;

using UnityEngine;
using TMPro;
using System;

public class DialogoScript : MonoBehaviour
{
    [SerializeField] private GameObject dialogueMark;
    [SerializeField] private GameObject dialogoPanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField, TextArea(4,6)] private string[] dialogueLines;

    public float typingTime = 0.05f;

    private bool isPlayerInRange;
    private bool didDialogueStart;
    private int lineIndex;


    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.Space))
        {
            if(!didDialogueStart){
              StartDialogue();  
            }
            else if (dialogueText.text == dialogueLines[lineIndex])
            {
                NextDialogueLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = dialogueLines[lineIndex];
            }
        }
    }

    public void StartDialogue()
    {
        didDialogueStart = true;
        dialogoPanel.SetActive(true);
        dialogueMark.SetActive(false);
        lineIndex = 0;
        Time.timeScale = 0f; // Pausa todo el juego
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
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if (lineIndex < dialogueLines.Length)
        {
            StartCoroutine(ShowDialogueLine());
        }
        else
        {
            didDialogueStart = false;
            dialogoPanel.SetActive(false);
            dialogueMark.SetActive(true); //quizas se retira, decidir mas tarde
            Time.timeScale = 1f; // Reanuda todo el juego
        }
    }   

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            dialogueMark.SetActive(true);
            Debug.Log("Inicio area dialogo");
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            dialogueMark.SetActive(false);
            Debug.Log("Fin area dialogo");
        }
    }
}
    
