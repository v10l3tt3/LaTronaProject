using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarBarro : MonoBehaviour
{
    public GameObject barroUnidadPrefab; // Prefab de la bola de barro
    //[SerializeField] private Transform shootPosition; // Punto de origen del disparo
    
    //public float velocidadDisparo = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //barroUnidadPrefab = Resources.Load<GameObject>("barroUnidad");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) // Cambia la tecla si quieres
        {
            //para el FXaudio
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxMudshot);
            //old
            Instantiate(barroUnidadPrefab, transform.position, Quaternion.identity);

           //tuto
            //Instantiate(barroUnidadPrefab, shootPosition.position, Quaternion.identity);
           
        }
    }
}
