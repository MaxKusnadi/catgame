using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
	public Text timer;
	private static float timeLeft;

	// Update is called once per frame
	void Update () {
		if (Main.currentState == Main.States.Game) 			{game_screen ();}
		else if (Main.currentState == Main.States.End) 		{end_screen();}
	}

	void game_screen (){
		if (Main.isGameOn && !isTimeUp ()) {
			showTimer();
		}
	}

	void showTimer(){
		float guiTime = calculateTimeLeft ();
		print ("time =" + guiTime);
		float minutes = Mathf.Floor(guiTime / 60);
		float seconds = Mathf.Floor(guiTime % 60);
		
		timer.text = string.Format ("{0:00}:{1:00}", minutes, seconds); 
	}

	float calculateTimeLeft(){
		return Main.timeLeft - Time.time; 
	}

	public static bool isTimeUp(){
		bool soln = (Main.timeLeft - Time.time) < 0;
		return soln;
	}

	void end_screen(){
		timer.text = string.Format ("{0:00}:{1:00}", 0, 0); 
	}
}
