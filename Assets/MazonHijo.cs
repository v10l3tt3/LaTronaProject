using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazonHijo : MonoBehaviour
{
    public string targetTag = "Target"; // tag escaleras
    public string basePointName = "BasePoint";

    private Transform targetBasePoint;
    private bool isFollowing = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void LateUpdate()
    {
        if (isFollowing && targetBasePoint != null)
        {
            transform.position = targetBasePoint.position;
        }
    }

    // Detectar contacto con el target
    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.CompareTag(targetTag))
        {
            // Buscar el punto BasePoint dentro del target
            Transform basePoint = other.transform.Find(basePointName);

            if (basePoint != null)
            {
                targetBasePoint = basePoint;
                isFollowing = true;
            }
            else
            {
                Debug.LogWarning($"No se encontró '{basePointName}' dentro del target.");
                targetBasePoint = other.transform; // fallback: seguir al target completo
                isFollowing = true;
            }
        }
    }
    
}
