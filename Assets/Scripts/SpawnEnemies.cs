using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

	public GameObject[] enemies;
	public float minWaitTime = 0.5f;
	public float maxWaitTime = 1.5f;

	private int enemyIndex;
	private GameObject clone;
	private Vector3 enemyPosition;
	private float bgWidth;
	private bool spawnEnemyInFront;
	private float enemyPosY;
	
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
			
						
			Vector3 pos = GameObject.FindWithTag("MainCamera").GetComponent<Camera>().ViewportToWorldPoint(new Vector3(1.0f, Random.value, 0.0f));

			if(spawnEnemyInFront = !spawnEnemyInFront){
				enemyPosY = transform.position.y; 
			}	
			else{
				enemyPosY = pos.y;
			}	
			
			if(enemies.Length > 0){
				
				enemyIndex = Random.Range(0,(enemies.Length));
				enemyPosition = new Vector3(pos.x, enemyPosY, 0.0f);
				clone = (GameObject)Instantiate (enemies[enemyIndex], enemyPosition, Quaternion.identity);
				DestroyObject(clone,5);
				if(Random.value > 0.5 && clone.GetComponent<AudioSource>())
					clone.GetComponent<AudioSource>().Play ();
			}		
		}	
	}
}



