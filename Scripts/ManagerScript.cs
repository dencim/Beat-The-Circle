using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour {

	public GameObject googlePlayUI;

	public GameObject moreInfoUI;

	public GameObject win;

	public Button googlePlayButton;
	public Button moreInfoButton;
	public Button soundButton;

	public Sprite soundOn;
	public Sprite soundOff;

	public AudioClip forwardSound;
	public AudioClip backSound;
	public AudioClip goalSound;

	public static bool goal = false;

	public static bool godMode = false;

	// Use this for initialization
	void Start () {

		googlePlayUI.gameObject.SetActive(false);
		moreInfoUI.gameObject.SetActive(false);

		if(Main.sound == true){
			
			soundButton.image.sprite = soundOn;

			
		}
		else{
			
			soundButton.image.sprite = soundOff; 

		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if(goal == true){
			if(Main.sound == true){
				audio.PlayOneShot(goalSound);
			}

			goal = false;
		}

		if(Main.level == 101){
			win.gameObject.SetActive(true);
		}

	
	}

	public void GooglePlay(){
		if(Main.sound == true){
			audio.PlayOneShot(forwardSound);
		}
		googlePlayUI.gameObject.SetActive(true);
		googlePlayUI.animation.Play("Google Play");
		Main.uiOpen = true;
		moreInfoButton.gameObject.SetActive(false);
		googlePlayButton.gameObject.SetActive(false);

	}

	public void GooglePlayClose(){
		if(Main.sound == true){
			audio.PlayOneShot(backSound);
		}
		googlePlayUI.animation.Play("Google Play Close");
		Main.uiOpen = false;
		moreInfoButton.gameObject.SetActive(true);
		googlePlayButton.gameObject.SetActive(true);

	}

	public void MoreInfo(){
		if(Main.sound == true){
			audio.PlayOneShot(forwardSound);
		}
		moreInfoUI.gameObject.SetActive(true);
		moreInfoUI.animation.Play("More Info");
		Main.uiOpen = true;
		moreInfoButton.gameObject.SetActive(false);
		googlePlayButton.gameObject.SetActive(false);
		
	}
	public void MoreInfoClose(){
		if(Main.sound == true){
			audio.PlayOneShot(backSound);
		}
		moreInfoUI.animation.Play("More Info Close");
		Main.uiOpen = false;
		moreInfoButton.gameObject.SetActive(true);
		googlePlayButton.gameObject.SetActive(true);

	}

	public void GodMode(){

		if(!godMode){
			godMode = true;
		}
		else{
			godMode = false;
		}

	}

	public void SoundSetting(){

		if(Main.sound == true){

			Main.sound = false;
			soundButton.image.sprite = soundOff;

		}
		else if(Main.sound == false){

			Main.sound = true;
			soundButton.image.sprite = soundOn;
		}
		else{
			Main.sound = true;
			soundButton.image.sprite = soundOn;
			//something went wrong
		}

	}

	public void Website(){
		Application.OpenURL("http:www.cimtekapps.com");
	}

	public void Restart(){
		Main.level = 1;
		Main.scoreDuringGame = 1;
		Main.scoreTemp = 1;
		win.gameObject.SetActive(false);
	}
	
}
