using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesInventarioScript : MonoBehaviour
{
    //test


    void Start()
    {

    }

    void Update()
    {

    }


    //funciones para botones generales
    public void ReturnMenu()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonOut);
        SceneManager.LoadScene("MenuUI", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxExitGame);
        Application.Quit();
    }
    
    public void ReturnHouse()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonOut);
        SceneManager.LoadScene("TilemapCasa", LoadSceneMode.Single);
        
    }


}