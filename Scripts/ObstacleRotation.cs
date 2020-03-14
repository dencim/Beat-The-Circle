using UnityEngine;
using System.Collections;

public class ObstacleRotation : MonoBehaviour {


	public Sprite otherObstacle;
	public Sprite squareObstacle;
	public AudioClip deathSound;

	public static bool soundDeath = false;

	float timer = 0;
	float timer2 = 0;
	float timer3 = 0;
	float timer4 = 0;
	float timer5 = 0;
	float timer6 = 0;
	float timer7 = 0;
	float timer8 = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Player.alive == true && Main.level <= 10){

			gameObject.transform.Rotate(0,0,29.5f * Time.deltaTime); //changed this speed //can change for everything else as well

		}
		else if(Player.alive == true && Main.level > 10 && Main.level <= 20){

			gameObject.transform.Rotate(0,0,-30.5f * Time.deltaTime);

		}
		else if(Player.alive == true && Main.level > 20 && Main.level <= 30){



			if(Player.alive == true){
				timer += 1 * Time.deltaTime;
			}

			if(timer <= 7.5f){
				gameObject.transform.Rotate(0,0,32 * Time.deltaTime);
			}
			else if(timer > 7.5f && timer <= 15){
				gameObject.transform.Rotate(0,0,-32 * Time.deltaTime);
			}
			else{
				timer = 0;
			}


		}
		else if(Player.alive == true && Main.level > 30 && Main.level <= 40){


			if(Player.alive == true){
				timer2 += 1 * Time.deltaTime;
			}
			
			if(timer2 <= 7){
				gameObject.transform.Rotate(0,0,33 * Time.deltaTime);
			}
			else if(timer2 > 7 && timer2 <= 16){
				gameObject.transform.Rotate(0,0,-33 * Time.deltaTime);
			}
			else{
				timer2 = 0;
			}


		}
		else if(Player.alive == true && Main.level > 40 && Main.level <= 50){

			if(Player.alive == true){
				timer3 += 1 * Time.deltaTime;
			}
			
			if(timer3 <= 7.5f){
				gameObject.transform.Rotate(0,0,33 * Time.deltaTime);
			}
			else if(timer3 > 7.5f && timer3 <= 13f){
				gameObject.transform.Rotate(0,0,-33 * Time.deltaTime);
			}
			else if(timer3 > 13f && timer3 <= 18f){
				gameObject.transform.Rotate(0,0,33 * Time.deltaTime);
			}
			else if(timer3 > 18 && timer3 <= 25){
				gameObject.transform.Rotate(0,0,-33 * Time.deltaTime);
			}
			else{
				timer3 = 0;
			}

		}
		else if(Player.alive == true && Main.level > 50 && Main.level <= 60){


			if(Player.alive == true){
				timer4 += 1 * Time.deltaTime;
			}
			
			if(timer4 <= 7.5f){
				gameObject.transform.Rotate(0,0,34 * Time.deltaTime);
			}
			else if(timer4 > 7.5f && timer4 <= 13f){
				gameObject.transform.Rotate(0,0,-34 * Time.deltaTime);
			}
			else if(timer4 > 13f && timer4 <= 15f){
				gameObject.transform.Rotate(0,0,34 * Time.deltaTime);
			}
			else if(timer4 > 15 && timer4 <= 20){
				gameObject.transform.Rotate(0,0,-34 * Time.deltaTime);
			}
			else{
				timer4 = 0;
			}



		}
		else if(Player.alive == true && Main.level > 60 && Main.level <= 70){

			if(Player.alive == true){
				timer5 += 1 * Time.deltaTime;
			}
			
			if(timer5 <= 7.5f){
				gameObject.transform.Rotate(0,0,34 * Time.deltaTime);
			}
			else if(timer5 > 7.5f && timer5 <= 9f){
				gameObject.transform.Rotate(0,0,-34 * Time.deltaTime);
			}
			else if(timer5 > 9f && timer5 <= 10f){
				gameObject.transform.Rotate(0,0,34 * Time.deltaTime);
			}
			else if(timer5 > 10 && timer5 <= 20){
				gameObject.transform.Rotate(0,0,-34 * Time.deltaTime);
			}
			else{
				timer5 = 0;
			}

		}
		else if(Player.alive == true && Main.level > 70 && Main.level <= 80){

			if(Player.alive == true){
				timer6 += 1 * Time.deltaTime;
			}

			if(timer6 <= 3f){
				gameObject.transform.Rotate(0,0,33 * Time.deltaTime);
			}
			else if(timer6 > 3f && timer6 <= 8.5f){
				gameObject.transform.Rotate(0,0,-34 * Time.deltaTime);
			}
			else if(timer6 > 8.5f && timer6 <= 13f){
				gameObject.transform.Rotate(0,0,34 * Time.deltaTime);
			}
			else if(timer6 > 14 && timer6 <= 16){
				gameObject.transform.Rotate(0,0,-35 * Time.deltaTime);
			}
			else if(timer6 > 16 && timer6 <= 20){
				gameObject.transform.Rotate(0,0,34 * Time.deltaTime);
			}
			else if(timer6 > 20 && timer6 < 25){
				gameObject.transform.Rotate(0,0,-34 * Time.deltaTime);
			}
			else{
				timer6 = 0;
			}

		}
		else if(Player.alive == true && Main.level > 80 && Main.level <= 90){

			if(Player.alive == true){
				timer7 += 1 * Time.deltaTime;
			}

			if(timer < 5){
				gameObject.transform.Rotate(0,0,34 * Time.deltaTime);
			}
			else if(timer7 > 5 && timer7 <= 7){
				gameObject.transform.Rotate(0,0,40 * Time.deltaTime);
			}
			else if(timer7 > 7 && timer7 < 13){
				gameObject.transform.Rotate(0,0,34 * Time.deltaTime);
			}
			else if(timer7 > 13 && timer7 < 15){
				gameObject.transform.Rotate(0,0,-40 * Time.deltaTime);
			}

			}
		else if(Player.alive == true && Main.level > 90 && Main.level <= 100){

			if(Player.alive == true){
				timer8 += Time.deltaTime;
			}

			if(timer8 <= 9){
				gameObject.transform.Rotate(0,0,-34 * Time.deltaTime);
			}
			else if(timer8 > 9 && timer8 < 10.5f){
				gameObject.transform.Rotate(0,0,60 * Time.deltaTime);
			}
			else if(timer8 > 10.5f && timer8 < 19.5f){
				gameObject.transform.Rotate(0,0,-34 * Time.deltaTime);
			}
			else if(timer8 > 19.5 && timer8 < 23){
				gameObject.transform.Rotate(0,0,-60 * Time.deltaTime);
			}
			else{
				timer8 = 0;
			}


		}
		else if(Main.level == 101){
			Debug.Log("You Win!");
		}
		else if(Main.level > 101){
			Debug.Log("Stop Hacking"); //
		}


		if(ManagerScript.godMode){
			gameObject.collider2D.isTrigger = true;
		}
		else{
			gameObject.collider2D.isTrigger = false;
		}


		if(soundDeath == true){
			if(Main.sound == true){
				audio.PlayOneShot(deathSound);
			}
			soundDeath = false;
		}

		if(Main.level > 30 && Main.level <= 50){
			gameObject.GetComponent<SpriteRenderer>().sprite = otherObstacle;
		}
		else if(Main.level > 50){
			gameObject.GetComponent<SpriteRenderer>().sprite = squareObstacle;
		}

	}
	
}
