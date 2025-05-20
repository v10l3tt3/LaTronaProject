using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliciaScript : MonoBehaviour
{
    public float poliSpeed = 5f;

    AudioSource _audioSourcePoli;
    void Start()
    {
        _audioSourcePoli = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadFinal = poliSpeed * Time.deltaTime;

        //mov fallido, revisar mas tarde
        //transform.position = new Vector3(transform.position.x - velocidadFinal, transform.position.y, transform.position.z);
    }
}
