using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoliciaScript : MonoBehaviour
{
    /// <summary>
    //public float poliSpeed = 1f;
    /// </summary>

    //float timeIsP;
    //float changeTime = 0.2f;

    
    

    AudioSource _audioSourcePoli;
    void Start()
    {
        //timeIsP = Time.time;
        _audioSourcePoli = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //float PvelocidadFinal = poliSpeed * Time.deltaTime;

        //mov fallido, revisar mas tarde
        //transform.position = new Vector3(transform.position.x - velocidadFinal, transform.position.y, transform.position.z);
        /*transform.Translate(-velocidadFinal, 0, 0, Space.World);

        //no funciona, pero es la idea
        if (transform.position.x == transform.position.x-3)
        {
            transform.Translate(velocidadFinal, 0, 0, Space.World);
        }*/
        //transform.Translate(Vector3.left * PvelocidadFinal, Space.World);



        //tampoco funciona 
        /*if (Time.time <= timeIsP + changeTime)
        {
            transform.Translate(Vector3.right * PvelocidadFinal, Space.World);
        }
        else if (Time.time >= timeIsP + changeTime)
        {
            transform.Translate(Vector3.left * PvelocidadFinal, Space.World);
        }*/

        //StartCoroutine(MovePolicia());     
           
        /*IEnumerator MovePolicia(){
           while (true){
            // Move to the left
            //transform.Translate(Vector3.left * PvelocidadFinal);
            transform.Translate(1*PvelocidadFinal, 0, 0, Space.World);
            yield return new WaitForSeconds(changeTime);

            // Move to the right
            //transform.Translate(Vector3.right * PvelocidadFinal);
            transform.Translate(-1*PvelocidadFinal, 0, 0, Space.World);
            yield return new WaitForSeconds(changeTime);
            } 
        }*/
         
         
        
        
        



    }
}
