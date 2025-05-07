using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    GameObject mainPanel;
    GameObject settingsPanel;
    void Start()
    {
        settingsPanel = GameObject.Find("SettingsPanel");
        settingsPanel.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("TilemapCasa");
    }

    public void ShowSettings()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonIn);
        settingsPanel.SetActive(true);
    }

    public void HideSettings()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonOut);
        settingsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxExitGame);
        Application.Quit();
    }

    public void ButtonSound(){
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxPlayButton);
    }

}
