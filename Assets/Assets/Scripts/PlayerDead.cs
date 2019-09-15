using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {

	public AudioClip explodeAudio;

	private int distance;
	private Animator animator;
	public string scene;
	
	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator> ();	
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D collider) {
		
		if (collider.gameObject.tag == "Enemy"){
		
			GetComponent<AudioSource>().Stop();
			GetComponent<AudioSource>().clip = explodeAudio;
			GetComponent<AudioSource>().Play();
			animator.SetBool("nyan_explode",true);
			Destroy(GetComponent<Rigidbody2D>());
			
		}
			
			
	}
	
	public void playerExplode(){

		distance = (int)(transform.position.x*10);		
		PlayerPrefs.SetInt("score",distance);
		GetComponent<Renderer>().enabled = false;
//		DestroyObject(gameObject, 2);
		Invoke( "LoadLevel", 2 );		
		
	}
	
	public void LoadLevel(){
		
		Application.LoadLevel(scene);
		
	}
						
}
