using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSound : MonoBehaviour
{
    private AudioSource animationSoundPLY;
    private bool alreadyPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        animationSoundPLY = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MocedadesSound()
    {
        if (!alreadyPlayed)
        {
            animationSoundPLY.Play();
            alreadyPlayed = true;
        }
    }
}
