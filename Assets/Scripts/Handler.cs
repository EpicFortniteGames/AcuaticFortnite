using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Handler : MonoBehaviour{ 
    public string scene;
    private bool loadlock;
    public int stocks;
    public GameObject player;
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
            lives playerscript = player.GetComponent<lives>();
            stocks = playerscript.live;
        }
        print(stocks);

        if(stocks == 0){
            print("in");
            button.gameObject.SetActive(true);
            button2.gameObject.SetActive(true);
        }
    }

    public void Restart(string scene){
        Application.LoadLevel(scene);
    }

    public void Menu(string scene){
        Application.LoadLevel(scene);
    }
}
