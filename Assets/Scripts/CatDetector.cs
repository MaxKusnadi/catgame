using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CatDetector : MonoBehaviour {
	public Text distance;
	
	// Update is called once per frame
	void Update () {
		if (Main.currentState == Main.States.Start) {
			distance.text = "The cat is -- rooms away!";
		}else if (Main.currentState == Main.States.Game) {
			game();
		}else if (Main.currentState == Main.States.End) {
			distance.text = "";
		}
	}

	void game(){
		List<int> manCoordinate = Main.currentRoom.getCoordinate ();
		List<int> catCoordinate = Cat.currentRoom.getCoordinate ();

		int dist;

		dist = Mathf.Abs (manCoordinate [0] - catCoordinate [0]) +
			   Mathf.Abs (manCoordinate [1] - catCoordinate [1]) +
			   Mathf.Abs (manCoordinate [2] - catCoordinate [2]);

		distance.text = "The cat is " + dist + " rooms away!";
	}

	public static int catDistance(){
		List<int> manCoordinate = Main.currentRoom.getCoordinate ();
		List<int> catCoordinate = Cat.currentRoom.getCoordinate ();
		
		int dist;
		
		dist = 	Mathf.Abs (manCoordinate [0] - catCoordinate [0]) +
				Mathf.Abs (manCoordinate [1] - catCoordinate [1]) +
				Mathf.Abs (manCoordinate [2] - catCoordinate [2]);
		return dist;
	}
}
