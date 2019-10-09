using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour{
    public GameObject player;
    public int lives;
    
    void Start(){
        
    }

    void Update(){
        PlayerMovement playerscript = player.GetComponent<PlayerMovement>();
        lives = playerscript.lives;
    }
}
