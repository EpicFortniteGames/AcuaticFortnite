using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Walls : MonoBehaviour
{

    public GameObject[] Walls;
    private Vector3 WallPosition_left;
    private Vector3 WallPosition_right;
    private GameObject clone_left;
    private GameObject clone_right;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWall());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnWall()
    {

        while (true)
        {
            yield return new WaitForSeconds(0.45f);
            Vector3 pos_left = GameObject.FindWithTag("MainCamera").GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.08f, 1.01f, 0.0f));
            Vector3 pos_right = GameObject.FindWithTag("MainCamera").GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.92f, 1.01f, 0.0f));
            WallPosition_left = new Vector3(pos_left.x, pos_left.y, -0.5f);
            WallPosition_right = new Vector3(pos_right.x, pos_right.y, -0.5f);
            clone_left = (GameObject)Instantiate(Walls[0], WallPosition_left, Quaternion.identity);
            clone_right = (GameObject)Instantiate(Walls[0], WallPosition_right, Quaternion.identity);
            DestroyObject(clone_left, 5);
            DestroyObject(clone_right, 5);

        }
    }
}