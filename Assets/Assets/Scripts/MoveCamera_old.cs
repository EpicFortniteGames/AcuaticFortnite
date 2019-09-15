using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	
	public int speed = 5;
	private float posX;
	private float posY;
	private float posZ;
	
	// Use this for initialization
	void Start () {
		
		posX = transform.position.x;
		posY = transform.position.y;
		posZ = transform.position.z;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		posY = transform.position.y;
		posX += speed * Time.deltaTime;
		transform.position = new Vector3(posX,posY,posZ);
	}
}
