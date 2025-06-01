using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AutoExitGameScript : MonoBehaviour
{
    public float cinematicTime;
    void OnEnable()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSecondsRealtime(cinematicTime);
        ExitGame();
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
