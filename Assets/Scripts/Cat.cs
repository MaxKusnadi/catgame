using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {

	public static Map.Room currentRoom;

	public static void newGame(){
		int roomNumber = Random.Range(1, 63);
		currentRoom = Map.roomList["room" + roomNumber];
	}

	public static void catMove(){
		if (Main.counter % 2 == 0) {
			randomMove();
		}
	}

	private static void randomMove(){
		int rnd = Random.Range (1, 62);
		if (rnd == 1) {
			if(currentRoom.moveForward() != null){
				currentRoom = currentRoom.moveForward ();
			}else{
				randomMove();
			}
		} else if (rnd == 2) {
			if(currentRoom.moveBehind() != null){
				currentRoom = currentRoom.moveBehind ();
			}else{
				randomMove();
			}
		} else if (rnd == 3) {
			if(currentRoom.moveLeft() != null){
				currentRoom = currentRoom.moveLeft ();
			}else{
				randomMove();
			}
		} else if (rnd == 4) {
			if(currentRoom.moveRight() != null){
				currentRoom = currentRoom.moveRight ();
			}else{
				randomMove();
			}
		} else if (rnd == 5) {
			if(currentRoom.moveUp() != null){
				currentRoom = currentRoom.moveUp ();
			}else{
				randomMove();
			}
		} else if (rnd == 6) {
			if(currentRoom.moveDown() != null){
				currentRoom = currentRoom.moveDown ();
			}else{
				randomMove();
			}
		}

	}

}
