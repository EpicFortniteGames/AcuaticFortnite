using UnityEngine;
using System.Collections;

public class MoveBackground : MonoBehaviour {
	public Transform secondaryBg;
	public float speed;
	private float bgHeight;
	private float posY;
	private float posX;
	private float newPosY;

	void Start() {
		bgHeight = GetComponent<Renderer>().bounds.size.y; // Acceder a la y del otro background
		posX=transform.position.x; // Misma x
	}
	void Update() {
		if(GetComponent<Rigidbody2D>()){
			GetComponent<Rigidbody2D>().velocity = new Vector2(0,-speed);
		}
	}
	void OnBecameInvisible() { // Metodo a aplicar cuando objeto salga de vision
		if(transform && secondaryBg){
			posY = secondaryBg.transform.position.y;
			newPosY = bgHeight + posY;
			transform.position = new Vector2(posX,newPosY);
		}
	}
}