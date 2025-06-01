using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MiniFusibles : MonoBehaviour
{
    float[] rotations = { 0, 180 };

    public float correctRotation;

    [SerializeField]
    bool isPlaced = false;

    //luces correctas
    public GameObject tinyLight;

    void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, 0);

        //para 1 sola solucion
        if (transform.eulerAngles.z == correctRotation)
        {
            isPlaced = true;
        }

        tinyLight = GameObject.FindGameObjectsWithTag("OnTinyLight")[0];
        tinyLight.SetActive(false);
        
    }

    void Update()
    {
        // No hay actualizaciones necesarias en este caso
    }

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 180));
        AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxFuseSwitch);

        //para 1 sola solucion
        if (transform.eulerAngles.z == correctRotation && isPlaced == false)
        {
            isPlaced = true;
            // Activar luz REVISAR
            var light2D = tinyLight.GetComponentInChildren<UnityEngine.Rendering.Universal.Light2D>();
            if (light2D != null)
            {
                light2D.enabled = true;
            }
        }
        else if (isPlaced == true)
        { isPlaced = false; }
    }
}
