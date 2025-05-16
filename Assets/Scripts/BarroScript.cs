using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarroScript : MonoBehaviour
{
    GameObject player;
    bool bolaBarro = true;

    float destructionTime = 5.0f;

    float timeIs;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        bolaBarro = player.GetComponent<MovPerson>().;

        timeIs = Time.time; //8s
    }

    // Update is called once per frame
    void Update()
    {
       if(bolaBarro){
            transform.Translate(0, 0.01f, 0, Space.World);
        }else{
           transform.Translate(0, -0.01f, 0, Space.World); 
        }
        
        if(Time.time >= timeIs+destructionTime){
            Destroy(this.gameObject);
        } 
    }
}
