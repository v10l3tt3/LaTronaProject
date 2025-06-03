using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip bandaSonora;

    public AudioClip creditsBandaSonora;
    public AudioClip fxButtonIn;
    public AudioClip fxButtonOut;

    public AudioClip fxPlayButton;
    public AudioClip fxExitGame;

    public AudioClip fxFuseSwitch;
    public AudioClip fxPipesClick;


    public AudioClip fxMovBienTub;
    public AudioClip fxLogroTub;
    public AudioClip fxLogroFuse;

    public AudioClip poliDolorOinkFX;
    public AudioClip fxLowHelicopter;

    public AudioClip fxPiece1;
    public AudioClip fxPiece2;

    public AudioClip fxPhotoCompleted;

    public GameObject musicObj;


    public AudioSource gestorAudio;
    public AudioSource audioMusic;

    //por si se quiere usar un mixer de audio al entrar en una zona:
    //public AudioMixerSnapshot burbujaSnapshot;
    public static AudioManager Instance { get; private set; }

    void Awake()
    {
        //Si existe otro objeto de este tipo, destruyelo
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(musicObj);
        }
    }

    void Start()
    {
        gestorAudio = this.GetComponent<AudioSource>();


        audioMusic = musicObj.GetComponent<AudioSource>();
        audioMusic.clip = bandaSonora;
        audioMusic.loop = true;
        audioMusic.volume = 0.1f;
        audioMusic.Play();
    }


    void Update()
    {

    }

    //Metodo seleccionador de clips de audio
    public void SonarClipUnaVez(AudioClip clipOnce)
    {
        gestorAudio.PlayOneShot(clipOnce, 1f);
    }
    

}
