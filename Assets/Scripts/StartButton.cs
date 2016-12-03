using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartButton : MonoBehaviour {
	public Text startButton;

	// Update is called once per frame
	void Update () {
		if (Main.currentState == Main.States.Game) 			{game_screen ();}
		else if (Main.currentState == Main.States.Start) 	{startButton.text = "Press Space to Start";}
		else if (Main.currentState == Main.States.End) 		{end_screen();}
	}

	void game_screen(){
		startButton.text = "";
	}

	void end_screen(){
		if (Main.isWin) {
			startButton.text = "You win! Press Space to continue";
		} else {
			startButton.text = "You lose! Press Space to continue";
		}
	}
}
