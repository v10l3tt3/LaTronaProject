using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToChangeScenebyTrigger : MonoBehaviour
{
    public int sceneBuildIndex; // Cambia este valor al índice de la escena que quieras cargar
    void Start() { }

    void Update() { }

    private void OnTriggerEnter2D(Collider2D colC)
    {
        print("Saliendo de la casa");
        if (colC.tag == "Player")
        {
            // Aquí puedes agregar cualquier lógica adicional que necesites antes de cambiar de escena
            // Por ejemplo, reproducir un sonido o mostrar un mensaje

            // Cambia a la escena especificada por el índice
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
