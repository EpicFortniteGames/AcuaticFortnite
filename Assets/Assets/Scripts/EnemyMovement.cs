using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	public float speedY = 1f;
	public float speedX = 0;
	
	void Start () {

		GetComponent<Rigidbody2D>().velocity = new Vector2(speedX,-speedY);
	}
	
	void Update () {
				

	}
}
