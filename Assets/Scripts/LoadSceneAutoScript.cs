using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAutoScript : MonoBehaviour
{
    public int sceneBuildIndex;
    public float cinematicTime;
   
    void OnEnable()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }
    
    private IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSecondsRealtime(cinematicTime);
         SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
}
