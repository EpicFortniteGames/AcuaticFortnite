using UnityEngine;
using System.Collections;

public class DistanceCounter : MonoBehaviour {

	public GUIText distanceCounter;
	public float spawnEnemiesSpeed = 0.01f;
	private SpawnEnemies spawnEnemies;
	private int distance;
	
	// Use this for initialization
	void Start () {

		spawnEnemies = GetComponent<SpawnEnemies>();

	}
	
	// Update is called once per frame
	void Update () {

		distance = (int)(transform.position.x*10);
		distanceCounter.text = "Distance " + distance;
		
		
		if ((distance % 100 == 0) && (spawnEnemies.minWaitTime > 0.1f) && (distance > 0)){
			
			spawnEnemies.minWaitTime = (float)System.Math.Round((spawnEnemies.minWaitTime - spawnEnemiesSpeed),2);
			spawnEnemies.maxWaitTime = (float)System.Math.Round((spawnEnemies.maxWaitTime - spawnEnemiesSpeed),2);
			GetComponent<AudioSource>().Play();
		
		}
	}
}
