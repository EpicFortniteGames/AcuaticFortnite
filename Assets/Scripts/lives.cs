using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour{
    public GameObject player;
    public int live;
    public Button button;
    public Button button2;
    
    void Start(){
        button = GameObject.FindGameObjectWithTag("button").GetComponent<Button>();
        button.gameObject.SetActive(false);
        button2 = GameObject.FindGameObjectWithTag("button2").GetComponent<Button>();
        button2.gameObject.SetActive(false);
    }

    void Update(){
        if(player){
            PlayerMovement playerscript = player.GetComponent<PlayerMovement>();
            live = playerscript.lives;
        }
        if(!player){
            button.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
        }
    }
}


