using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private float velocityX;
	public float speed = 2f;
	//public float forceX = 2f;
	
	//private float forceY;
	
	void Start () {
		
		//GetComponent<Rigidbody2D>().velocity = new Vector2(forceX,0);
		
	}
	
	void Update () {
		velocityX = 0f;
		if (Input.GetKey ("right")) {
			velocityX = speed;

		}
		if (Input.GetKey ("left")) {
			velocityX = -speed;
		}
		
		if(GetComponent<Rigidbody2D>()){
			GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX,0);
		}
	}
}

