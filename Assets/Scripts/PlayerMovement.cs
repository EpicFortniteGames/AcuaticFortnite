using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private float velocityX;
	public float speed = 2f;
	public GameObject balita;
	private GameObject clone;
	Vector3 balitaPosVector;
	Vector3 pos;
	public float spawny = 0.25f;
	public float fireRate = 1f;
	float nextFire = 0.0f;
	public int lives;
	public int score;
    private bool invincible;
    private float invtime;
    private Animator explosion;
    public AudioClip explodeAudio;
    public int last_score;
	
	void Start () {
		lives = 3;
		score = 0;
        invincible = false;
        explosion = GetComponent<Animator>();
        print(explosion);
        explosion.SetBool("is_exploding",false);
    }
    void Update()
    {
        if (invincible == true)
        {
            StartCoroutine(Immortal());
            if (Time.time > invtime + 1.5f)
            {
                invincible = false;
            }
        }
        velocityX = 0f;
        if (Input.GetKey("right"))
        {
            velocityX = speed;

        }
        if (Input.GetKey("left"))
        {
            velocityX = -speed;
        }

        if (GetComponent<Rigidbody2D>())
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, 0);
        }

        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
        }
        if(last_score < score){
            GetComponent<AudioSource>().Stop();
			GetComponent<AudioSource>().clip = explodeAudio;
			GetComponent<AudioSource>().Play();
            last_score = score;
        }
    }

	void fire(){
		balitaPosVector = transform.position;
		balitaPosVector.y += spawny;
		clone = (GameObject)Instantiate (balita, balitaPosVector, Quaternion.identity);
	}

    IEnumerator Immortal(){ // Hacer que parpadee
        while (invincible == true && lives > 0){
            GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(.1f);
            GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(.1f);
        }
    }

	void OnCollisionEnter2D(Collision2D collider){
        if (collider.gameObject.tag == "Enemy"){
            if (invincible == false){
                lives--;
                invincible = true;
                invtime = Time.time;
            }
            Destroy(collider.gameObject);
            if (lives == 0){
                GetComponent<AudioSource>().Stop();
			    GetComponent<AudioSource>().clip = explodeAudio;
			    GetComponent<AudioSource>().Play();
                explosion.SetBool("is_exploding", true);
                print("Your score is:" + score);
                
            }
            //GetComponent<Collider>().enabled = false;
        }
	}

    public void explode_boat(){
        Destroy(gameObject);
    }
}

