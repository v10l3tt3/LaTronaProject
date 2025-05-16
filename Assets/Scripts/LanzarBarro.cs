using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarBarro : MonoBehaviour
{
    public GameObject bolaBarroPrefab;
    
    public float velocidadDisparo = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Cambia la tecla si quieres
        {
            Instantiate(bolaBarroPrefab, transform.position, Quaternion.identity);
        }
    }
}
