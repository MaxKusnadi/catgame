using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Main : MonoBehaviour {
	public static bool isGameOn;
	public enum States {Start, Game, End};
	public static States currentState;
	public static Map.Room currentRoom;
	public static int counter;
	public static bool isWin;
	public static float timeLeft;

	// Use this for initialization
	void Start () {
		Map.create3x3Map();
		currentState = States.Start;
		counter = 0;
		timeLeft = 60;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentState == States.Start) { startScreen(); }	
		else if(currentState == States.Game) { gameScreen(); }
		else if (currentState == States.End) { gameOver(); }
	}

	void startScreen(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			currentState = States.Game;
			resetStatic ();
			foreach(KeyValuePair<string, Map.Room> a in Map.roomList){
				print (a.Key + " " + a.Value);
			}
		}
	}

	void resetStatic(){
		isGameOn = true;
		currentRoom = Map.start;
		Cat.newGame();
		isWin = false;
		timeLeft = Time.time + 60;
	}

	void gameScreen(){
		List<int> coordinate = currentRoom.getCoordinate();
		List<int> catCoordinate = Cat.currentRoom.getCoordinate ();
		print ("x: " + coordinate [0] + " y: " + coordinate [1] + " level: " + coordinate [2]);
		print ("Cat: x: " + catCoordinate [0] + " y: " + catCoordinate [1] + " level: " + catCoordinate [2]);
		if (Timer.isTimeUp()) {
			currentState = States.End;
			isGameOn = false;
		}
		if (CatDetector.catDistance () == 0) {
			isGameOn = false;
			isWin = true;
			currentState = States.End;
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			if(currentRoom.moveForward() != null){
				counter++;
				print("Move forward successful");
				currentRoom = currentRoom.moveForward();
				Cat.catMove();

			}else{
				print("invalid move");
			}
		}else if (Input.GetKeyDown (KeyCode.A)) {
			if(currentRoom.moveLeft() != null){
				counter++;
				print("Move left successful");
				currentRoom = currentRoom.moveLeft();
				Cat.catMove();
			}else{
				print("invalid move");
			}
		}else if (Input.GetKeyDown (KeyCode.S)) {
			if(currentRoom.moveBehind() != null){
				counter++;
				print("Move behind successful");
				currentRoom = currentRoom.moveBehind();
				Cat.catMove();
			}else{
				print("invalid move");
			}
		}else if (Input.GetKeyDown (KeyCode.D)) {
			if(currentRoom.moveRight() != null){
				counter++;
				print("Move right successful");
				currentRoom = currentRoom.moveRight();
				Cat.catMove();
			}else{
				print("invalid move");
			}
		}else if (Input.GetKeyDown (KeyCode.C)) {
			if(currentRoom.moveUp() != null){
				counter++;
				print("Move up successful");
				currentRoom = currentRoom.moveUp();
				Cat.catMove();
			}else{
				print("invalid move");
			}
		}else if (Input.GetKeyDown (KeyCode.V)) {
			if(currentRoom.moveDown() != null){
				counter++;
				print("Move down successful");
				currentRoom = currentRoom.moveDown();
				Cat.catMove();
			}else{
				print("invalid move");
			}
		}

	}

	void gameOver(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			currentState = States.Start;
		}
	}
}
