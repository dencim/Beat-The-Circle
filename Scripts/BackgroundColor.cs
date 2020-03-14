using UnityEngine;
using System.Collections;

public class BackgroundColor : MonoBehaviour {

	public Color red1, red2;
	public Color color1;
	public Color color2;
	public Color color3;
	public Color color4;
	public Color color5;
	public Color color6;
	public Color color7;
	public Color color8;
	public Color color9;
	public Color color10;
	public Color color11;
	public Color color12;
	public Color color13;
	public Color color14;
	public Color color15;
	public Color color16;
	public Color color17;
	public Color color18;
	public Color color19;
	public Color color20;
	public float duration = 3.0f;
	
	Camera camera;
	
	void Start() {

		camera = GetComponent<Camera>();
		camera.clearFlags = CameraClearFlags.SolidColor;

	}
	
	void Update() {
		if(Main.level <= 10){
			ColorOneToTwo();
		}
		else if(Main.level > 10 && Main.level <= 20){
			float t = Mathf.PingPong(Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp(color3, color4, t);
		}
		else if(Main.level > 20 && Main.level <= 30){
			float t = Mathf.PingPong(Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp(color5, color6, t);
		}
		else if(Main.level > 30 && Main.level <= 40){
			float t = Mathf.PingPong(Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp(color7, color8, t);
		}
		else if(Main.level > 40 && Main.level <= 50){
			float t = Mathf.PingPong(Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp(color9, color10, t);
		}
		else if(Main.level > 50 && Main.level <= 60){
			float t = Mathf.PingPong(Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp(color11, color12, t);
		}
		else if(Main.level > 60 && Main.level <= 70){
			float t = Mathf.PingPong(Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp(color13, color14, t);
		}
		else if(Main.level > 70 && Main.level <= 80){
			float t = Mathf.PingPong(Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp(color15, color16, t);
		}
		else if(Main.level > 80 && Main.level <= 90){
			float t = Mathf.PingPong(Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp(color17, color18, t);
		}
		else if(Main.level > 90 && Main.level <= 100){
			float t = Mathf.PingPong(Time.time, duration) / duration;
			camera.backgroundColor = Color.Lerp(color19, color20, t);
		}
		else if(Main.level >= 90){
			ColorOneToTwo();
			//You Win The Game!!
		}


		///////////////dead color

		if(Player.alive == false){
			ColorDead();
		}

	}

	public void ColorDead(){
		float t = Mathf.PingPong(Time.time, duration) / duration; 
		camera.backgroundColor = Color.Lerp(red1, red2, t);
	}

	public void ColorOneToTwo(){
		float t = Mathf.PingPong(Time.time, duration) / duration; 
		camera.backgroundColor = Color.Lerp(color1, color2, t); 
	}
	

}
