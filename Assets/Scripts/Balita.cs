using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balita : MonoBehaviour{
    public float velX = 0;
    float velY = 5f;
    public GameObject player; 
    Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        rb.velocity = new Vector2(velX, velY);
    }

    void OnCollisionEnter2D(Collision2D collider){
        if(collider.gameObject.tag == "Enemy"){
            PlayerMovement playerscript = player.GetComponent<PlayerMovement>();
            Destroy(collider.gameObject);
            Destroy(gameObject);
            playerscript.score += 100;
        }
    }
}