using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class PlayGame : MonoBehaviour {

	public float timer = 5;

	public GameObject backgroundMusic;
	
	void Start () {
		PlayGamesPlatform.Activate();
		Social.localUser.Authenticate((bool success) => {
			if(success){

			}
		});

	}

	void Update () {

		timer -= 1 * Time.deltaTime;

		if(timer <= 0){
			Application.LoadLevel(1);
		}

	/*	if(timer <= 2){
			backgroundMusic.gameObject.SetActive(true); //this is for music
		}
	*/ 

	
	}

}
