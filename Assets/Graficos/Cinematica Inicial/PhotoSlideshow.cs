using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoSlideshow : MonoBehaviour
{
    public List<Sprite> photos;               // Lista de fotos
    public float normalInterval = 4.0f;       // Tiempo entre fotos normales
    public float fastInterval = 2f;         // Tiempo para las últimas fotos rápidas
    public int fastCount = 4;                 // Cuántas fotos finales son rápidas
    public float lastPhotoDuration = 6.0f;    // Tiempo especial para la última foto
    public Image displayImage;                // Componente UI donde se muestran

    void Start()
    {
        StartCoroutine(ShowPhotos());
    }

    IEnumerator ShowPhotos()
    {
        for (int i = 0; i < photos.Count; i++)
        {
            displayImage.sprite = photos[i];

            // Si es la última imagen
            if (i == photos.Count - 1)
            {
                yield return new WaitForSeconds(lastPhotoDuration);
            }
            // Si está entre las últimas rápidas (pero no es la última)
            else if (i >= photos.Count - fastCount)
            {
                yield return new WaitForSeconds(fastInterval);
            }
            // Todas las demás
            else
            {
                yield return new WaitForSeconds(normalInterval);
            }
        }
    }
}