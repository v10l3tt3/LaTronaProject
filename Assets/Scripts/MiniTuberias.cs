using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniTuberias : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //falta seguir tutorial de discord
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, 0, -90);
            Debug.Log("Click");
        }
    }
    void OnMouseDown(){
    
        Debug.Log("Click");
    }
    
}
