using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static bool alive = true;
	public static bool deadAnim = false;
	public AudioClip goal;

	// Use this for initialization
	void Start () {

	}

	float fallingSpeed = 1.25f;
	
	// Update is called once per frame
	void Update () {

		rigidbody2D.AddRelativeForce(Vector2.up * fallingSpeed - rigidbody2D.velocity );
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.CompareTag("Obstacle") && ManagerScript.godMode == false){
			ObstacleRotation.soundDeath = true;
			Ads.deadAds = true;
			alive = false;
			deadAnim = true;
			SocialPlatform.bigShot = 0;
			Destroy (gameObject);

		}
		else{
			Debug.Log("God mode!");
		}

	}
	

	void OnTriggerEnter2D(Collider2D collision2){

		if(collision2.gameObject.CompareTag("Finish")){
			ManagerScript.goal = true;
			Main.playerActive = false;
			Main.scoreTemp --;
			SocialPlatform.bigShot++;
			Destroy(gameObject);

		
			
		}

	}
}
