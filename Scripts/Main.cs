using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Main : MonoBehaviour {


	public GameObject player;
	public GameObject levelTextObject;

	public GameObject moreInfo;
	public GameObject googlePlay;

	public Camera camera;

	public static int level = 1;  //the current level - the highest level the user got to - it is the one that saves and loads
	public Text levelText;
	public static int scoreDuringGame = 1; //Score from 1 - 10
	public Text scoreDuringGameText;
	public static int scoreTemp = 1; //counts down

	public static bool playerActive = false;

	public static bool uiOpen = false;

	public static bool sound = true;

	public AudioClip finishedLevel;
	public AudioClip shoot;

	public InputField goToLevel; //taking this out

	void OnEnable(){
		Load ();
		scoreTemp = scoreDuringGame;

	}

	void Start () {

		//level = 1; scoreTemp = 1; scoreDuringGame = 1;
	

	}//End of Start Function

	void Update () {

		//taking out

		if(goToLevel.text != "")
		{
			level = int.Parse(goToLevel.text);
		}

		//taking out

		levelText.text = "Level " + level.ToString();

		if(Input.GetMouseButtonDown(0) && Player.alive == true && playerActive == false && uiOpen == false){
		
			RaycastHit2D hit = Physics2D.Raycast (camera.ScreenToWorldPoint((Input.GetTouch (0).position)), Vector2.zero);
	//		if(hit.collider.CompareTag("Flag"))
			if(hit.collider == null)
			{
				if(sound == true){
					audio.PlayOneShot(shoot);
				}
				Instantiate(player,new Vector2(0,-3.35f),transform.rotation);
				playerActive = true;
			}

		}
		else if(Input.GetMouseButtonDown(0) && Player.alive == false && uiOpen == false){

			RaycastHit2D hit = Physics2D.Raycast (camera.ScreenToWorldPoint((Input.GetTouch (0).position)), Vector2.zero);
			//if(hit.transform.position != moreInfo.transform.position && hit.transform.position != googlePlay.transform.position)
			if(hit.collider == null)
			{
				Player.alive = true;
				playerActive = false;
				scoreTemp = scoreDuringGame;
				Ads.alreadyWatchedAd = false;
			}

		}


		//////////////////////////////////////////////
		/// Keeping track and displaying Score

		if(scoreTemp == 0){
			//Animation that brings it above screen
			if(sound == true){
				audio.PlayOneShot(finishedLevel);
			}

			levelTextObject.animation.Play("LevelAnim2");
			level ++;
			levelTextObject.animation.Play("levelAnim1");
			SocialPlatform.sendToLeaderboard = true;
			//scoreDuringGame = level; //change this so that it is the ones digit of level ex. level = 12, scoreDuringGame = 2
			if(scoreDuringGame < 10){
				scoreDuringGame ++;
				scoreTemp = scoreDuringGame;
			}
			else if(scoreDuringGame == 10){
				scoreDuringGame = 1; //new level
				scoreTemp = scoreDuringGame;
			}
			else{
				scoreDuringGame = 1; //new level
				scoreTemp = scoreDuringGame;
			}


		}

	
		scoreDuringGameText.text = scoreTemp.ToString();

		if(Player.deadAnim == true){
			camera.animation.Play("Shake");
			Player.deadAnim = false;
		}


	} //End of Update Function
	

	void OnApplicationQuit(){
		Save ();
	}
	void OnApplicationPause(){
		Save ();
	}
	
	void OnDisable(){
		Save();
	}

	public void Save(){
		
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/playerinfo.dat");


		PlayerData data = new PlayerData();
		data.level = level;
		data.scoreDuringGame = scoreDuringGame;
		data.sound = sound;

		data.gettingStartedAchievementBool = SocialPlatform.gettingStartedAchievementBool;
		data.bigShotAchievementBool = SocialPlatform.bigShotAchievementBool;
		data.professionalAchievementBool = SocialPlatform.professionalAchievementBool;
		data.level10AchievementBool = SocialPlatform.level10AchievementBool;
		data.level20AchievementBool = SocialPlatform.level20AchievementBool;
		data.level50AchievementBool = SocialPlatform.level50AchievementBool;
		data.level80AchievementBool = SocialPlatform.level80AchievementBool;
		data.wonGameAchievementBool = SocialPlatform.wonGameAchievementBool;




		
		bf.Serialize(file, data);
		file.Close();
	}

	public void Load(){
		
		if(File.Exists(Application.persistentDataPath + "/playerinfo.dat")){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerinfo.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close();

			level = data.level;
			scoreDuringGame = data.scoreDuringGame;
			sound = data.sound;

			SocialPlatform.gettingStartedAchievementBool = data.gettingStartedAchievementBool;
			SocialPlatform.bigShotAchievementBool = data.bigShotAchievementBool;
			SocialPlatform.professionalAchievementBool = data.professionalAchievementBool;
			SocialPlatform.level10AchievementBool = data.level10AchievementBool;
			SocialPlatform.level20AchievementBool = data.level20AchievementBool;
			SocialPlatform.level50AchievementBool = data.level50AchievementBool;
			SocialPlatform.level80AchievementBool = data.level80AchievementBool;
			SocialPlatform.wonGameAchievementBool = data.wonGameAchievementBool;

		}
	}


}

[Serializable]
class PlayerData{
	
	public int level;
	public int scoreDuringGame;
	public bool sound;

	public bool gettingStartedAchievementBool;
	public bool bigShotAchievementBool;
	public bool professionalAchievementBool;
	public bool level10AchievementBool;
	public bool level20AchievementBool;
	public bool level50AchievementBool;
	public bool level80AchievementBool;
	public bool wonGameAchievementBool;

}
