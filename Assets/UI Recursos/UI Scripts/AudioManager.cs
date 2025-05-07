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

    public AudioClip fxPiece1;
    public AudioClip fxPiece2;
    public AudioClip fxPiece3;

    public AudioClip fxPhotoCompleted;

    public GameObject musicObj;

    public static AudioManager Instance;
    AudioSource gestorAudio;
    AudioSource audioMusic;

    //por si se quiere usar un mixer de audio al entrar en una zona:
    //public AudioMixerSnapshot burbujaSnapshot;

    void Awake()
    {
        //Si existe otro objeto de este tipo, destruyelo
        if (Instance != null && Instance != this){
            Destroy(Instance.gameObject);
        }else{
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
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
    public void SonarClipUnaVez(AudioClip ac){
        gestorAudio.PlayOneShot(ac, 1f);
    }
}
