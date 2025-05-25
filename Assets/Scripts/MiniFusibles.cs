using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniFusibles : MonoBehaviour
{
    float[] rotations = { 0, 180 };

    public float correctRotation;
    [SerializeField]
    bool isPlaced = false;
    void Start()
    {
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        //para 1 sola solucion
        if (transform.eulerAngles.z == correctRotation)
        {
            isPlaced = true;
        }
    }

    void Update()
    {}

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 180));
        Debug.Log("Click");

        //para 1 sola solucion
        if (transform.eulerAngles.z == correctRotation && isPlaced == false)
        {
            isPlaced = true;
        }
        else if (isPlaced == true)
        {
            isPlaced = false;
        }
    }
}
