using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesInventarioScript : MonoBehaviour
{
    //test
        GameObject mainPanel;
    GameObject cablesPanel;
    GameObject tuberiasPanel;
    GameObject cochePanel;

    void Start()
    {
        cablesPanel = GameObject.Find("CablesPanel");
        cablesPanel.SetActive(false);
        tuberiasPanel = GameObject.Find("TuberiasPanel");
        tuberiasPanel.SetActive(false);
        cochePanel = GameObject.Find("CochePanel");
        cochePanel.SetActive(false);
    }
    
    void Update()
    {
        
    }


    //funciones para botones generales
    public void ReturnMenu()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonOut);
        SceneManager.LoadScene("MenuUI");
    }

    public void ExitGame()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxExitGame);
        Application.Quit();
    }




    //funciones para iniciar paneles de minijuegos
    //CABLES
    public void ShowCables()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonIn);
        cablesPanel.SetActive(true);
    }
    public void HideCables()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonOut);
        cablesPanel.SetActive(false);
    }


    //TUBERIAS
    public void ShowTuberias()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonIn);
        tuberiasPanel.SetActive(true);
    }

    public void HideTuberias()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonOut);
        tuberiasPanel.SetActive(false);
    }


    //COCHE
    public void ShowCoche()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonIn);
        cochePanel.SetActive(true);
    }
    public void HideCoche()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonOut);
        cochePanel.SetActive(false);
    }
}