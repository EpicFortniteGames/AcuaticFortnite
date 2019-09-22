using UnityEngine;
using System.Collections;

public class SpawnEnemiesLite : MonoBehaviour {
	
	public GameObject[] enemies;
	public float minWaitTime = 0.5f;
	public float maxWaitTime = 1.5f;
	
	private int enemyIndex;
	private GameObject clone;
	private Vector3 enemyPosition;
	private float bgWidth;
	private bool spawnEnemyInFront;
	private float enemyPosX;
	
	// Use this for initialization
	void Start () {
		
		StartCoroutine(SpawnEnemy());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator SpawnEnemy() {
		
		while(true){
			
			yield return new WaitForSeconds(Random.Range(minWaitTime,maxWaitTime));
			
			
			Vector3 pos = GameObject.FindWithTag("MainCamera").GetComponent<Camera>().ViewportToWorldPoint(new Vector3(Random.Range(0.15f,0.85f), 1.0f, 0.0f));
			
			if(spawnEnemyInFront = !spawnEnemyInFront){
				enemyPosX = transform.position.x; 
			}	
			else{
				enemyPosX = pos.x;
			}	
			
			if(enemies.Length > 0){
				
				enemyIndex = Random.Range(0,(enemies.Length));
				enemyPosition = new Vector3(enemyPosX, pos.y, 0.0f);
				clone = (GameObject)Instantiate (enemies[enemyIndex], enemyPosition, Quaternion.identity);
				/*if(Random.value > 0.5 && clone.GetComponent<AudioSource>())
					clone.GetComponent<AudioSource>().Play ();*/
			}		
		}	
	}
}



