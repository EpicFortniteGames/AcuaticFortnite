using UnityEngine;
using System.Collections;

public class PlayerDeadLite : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collider) {
		
		if (collider.gameObject.tag == "Enemy"){
			if(gameObject. GetComponent<AudioSource>().GetComponent<AudioSource>()) 
			{
				gameObject.GetComponent<AudioSource>().GetComponent<AudioSource>().Play();
			}
			Destroy(gameObject,2);
			
		}
		
		
	}
	
	
}
