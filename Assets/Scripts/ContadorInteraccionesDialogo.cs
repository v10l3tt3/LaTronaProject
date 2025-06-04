using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorInteraccionesDialogo : MonoBehaviour
{
    
    void Start()
    {}

    
    void Update()
    {
        if (GameManager.contadorInteracciones == 1)
        {
            //GameObject.Find("Senyora-Intro").SetActive(false);
            
        }
        else if (GameManager.contadorInteracciones == 2)
        {
            //GameObject.Find("VIntro-Agua").SetActive(false);
            //GameObject.Find("Pages-Intro-daAgua").SetActive(false);
            GameManager.Instance.tePidieronAgua = true;
        }
        else if (GameManager.contadorInteracciones == 3)
        {
            GameObject.Find("Pages-Intro-daAgua").SetActive(true);
            GameManager.Instance.agua = true;

        }
        
        
           
        
    }
}
