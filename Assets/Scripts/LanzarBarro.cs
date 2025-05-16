using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarBarro : MonoBehaviour
{
    public GameObject bolaBarroPrefab;
    public Transform puntoDisparo;
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
            DispararBolaBarro();
        }

    }
    
    void DispararBolaBarro()
    {
        GameObject bola = Instantiate(bolaBarroPrefab, puntoDisparo.position, Quaternion.identity);
        BarroScript scriptBola = bola.AddComponent<BarroScript>();
        scriptBola.Inicializar(transform.position, velocidadDisparo);
    }
}
