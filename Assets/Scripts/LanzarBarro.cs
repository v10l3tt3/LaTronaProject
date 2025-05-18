using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarBarro : MonoBehaviour
{
    public GameObject Barro_0Prefab; // Prefab de la bola de barro
    
    public float velocidadDisparo = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Barro_0Prefab = Resources.Load<GameObject>("Barro_0");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) // Cambia la tecla si quieres
        {
            //para el FXaudio
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxMudshot);
            Instantiate(Barro_0Prefab, transform.position, Quaternion.identity);
        }
    }
}
