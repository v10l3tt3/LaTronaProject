using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    GameObject mainPanel;
    GameObject settingsPanel;

    GameObject controlsPanel;



    void Start()
    {
        settingsPanel = GameObject.Find("OptionsPanel");
        settingsPanel.SetActive(false);

        controlsPanel = GameObject.Find("ControlsPanel");
        controlsPanel.SetActive(false);
    }


    void Update()
    {

    }

    public void StartGame()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxPlayButton);
        SceneManager.LoadScene("TilemapPueblo");
    }

    public void SkipCinematic()
    {

        SceneManager.LoadScene(1);
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

    public void ShowControls()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonIn);
        controlsPanel.SetActive(true);
    }

    public void HideControls()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxButtonOut);
        controlsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxExitGame);
        Application.Quit();
    }

    public void ButtonSound()
    {
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxPlayButton);
    }


}
