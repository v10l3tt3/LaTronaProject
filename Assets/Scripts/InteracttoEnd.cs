using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InteracttoEnd : MonoBehaviour
{
    private bool isPlayerInRange;

    [SerializeField] private GameObject dialogueMark;
    void Start()
    {

    }
    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.Space))
        { SceneManager.LoadScene(10, LoadSceneMode.Single); }
    }
    
    private void OnTriggerEnter2D(Collider2D colI)
    {
        if (colI.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            dialogueMark.SetActive(true);
            
        }
    }
    private void OnTriggerExit2D(Collider2D colII)
    {
        if (colII.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            dialogueMark.SetActive(false);
            
        }
    }
}
