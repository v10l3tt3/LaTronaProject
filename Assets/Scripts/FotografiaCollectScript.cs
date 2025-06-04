using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FotografiaCollectScript : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D colC){
        if(colC.gameObject.tag == "Player"){
            GameManager.Instance.fotomitades += 1;
            
            
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxPhotoCompleted);
            Destroy(this.gameObject, 0.1f);
        }
    }
}
