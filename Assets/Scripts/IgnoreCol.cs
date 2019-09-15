using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCol : MonoBehaviour
{

    public GameObject box1;
    public GameObject box2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(box1.GetComponent<Collider2D>(), box2.GetComponent<Collider2D>());
    }
}
