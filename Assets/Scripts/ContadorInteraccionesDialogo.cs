using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorInteraccionesDialogo : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.contadorInteracciones == 1)
        {
            GameObject.Find("Senyora-Intro").SetActive(false);
        }

        if (GameManager.Instance.contadorInteracciones == 2)
        {
            //GameObject.Find("VIntro-Agua").SetActive(false);
            //GameObject.Find("Pages-Intro-daAgua").SetActive(false);
            GameManager.Instance.tePidieronAgua = true;
        }

        if (GameManager.Instance.contadorInteracciones == 3)
        {
            GameObject.Find("Pages-Intro-daAgua").SetActive(true);
            GameManager.Instance.agua = true;

        }
        
        
           
        
    }
}
