using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    void OnCollisionEnter2D(Collision2D collider){
        if(collider.gameObject.tag == "Enemy" || collider.gameObject.tag == "balita"){
            Destroy(collider.gameObject);
        }
    }
}
