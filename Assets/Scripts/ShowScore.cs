using UnityEngine;
using System.Collections;

public class ShowScore : MonoBehaviour {

	private int score;
	private int hiScore;
	public GUIText scoreText;
	
	// Use this for initialization
	void Start () {
	
		score = PlayerPrefs.GetInt("score");
		hiScore = PlayerPrefs.GetInt("hiScore");
		
		if(hiScore < score){
			
			hiScore = score;
			PlayerPrefs.SetInt("hiScore",hiScore);
			
		}
		
		scoreText.text = "Score: " + score + "\n\nRecord: " + hiScore;
		
	}
	
	// Update is called once per frame
	void Update () {
	
			
	
	}
}
