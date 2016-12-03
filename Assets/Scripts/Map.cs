using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour {

	public class Room{
		private Room forward;
		private Room left;
		private Room right;
		private Room behind;
		private Room up;
		private Room down;
		private int x;
		private int y;
		private int level;

		public Room(int x, int y, int level){
			this.x = x;
			this.y = y;
			this.level = level;
		}

		public List<int> getCoordinate(){
			List<int> soln = new List<int>();
			soln.Add (x);
			soln.Add (y);
			soln.Add (level);
			return soln;
		}

		public void setForward(Room r){
			this.forward = r;
		}

		public void setBehind(Room r){
			this.behind = r;

		}

		public void setRight(Room r){
			this.right = r;
		}

		public void setLeft(Room r){
			this.left = r;
		}

		public void setUp(Room r){
			this.up = r;
		}

		public void setDown(Room r){
			this.down = r;
		}

		public Room moveForward(){
			return this.forward;
		}

		public Room moveBehind(){
			return this.behind;
		}

		public Room moveRight(){
			return this.right;
		}

		public Room moveLeft(){
			return this.left;
		}

		public Room moveUp(){
			return this.up;
		}

		public Room moveDown(){
			return this.down;
		}

	}

	public static Room start;
	public static Room cat;
	public static Dictionary<string, Room> roomList;

	//create 2x2 map
	public static void createMap(){
		roomList = new Dictionary<string, Room> ();
		start = new Room (1,1,1);
		int counter = 1;
		for (int i = 1; i < 5; i++) {
			if(i == 1){
				roomList.Add ("start", start);
			}else{
				roomList.Add ("room" + counter, new Room(1,2,i));
				counter ++;
			}
			roomList.Add ("room" + counter, new Room (1, 2, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (1, 3, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (1, 4, i));
			counter ++;

			roomList.Add ("room" + counter, new Room (2, 1, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (2, 2, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (2, 3, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (2, 4, i));
			counter ++;
			
			roomList.Add ("room" + counter, new Room (3, 1, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (3, 2, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (3, 3, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (3, 4, i));
			counter ++;

			roomList.Add ("room" + counter, new Room (4, 1, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (4, 2, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (4, 3, i));
			counter ++;
			roomList.Add ("room" + counter, new Room (4, 4, i));
			counter ++;
		}

	}

	public static void create3x3Map(){
		createMap ();
		//level 1
		createDoorUp(roomList["start"], roomList["room16"]);
		createDoorRight (roomList["start"], roomList["room1"]);

		createDoorForward (roomList["room1"], roomList["room5"]);

		createDoorRight (roomList["room2"], roomList["room3"]);

		createDoorForward (roomList["room3"], roomList["room7"]);

		createDoorUp (roomList["room4"], roomList["room8"]);

		createDoorRight (roomList["room5"], roomList["room6"]);

		createDoorRight (roomList["room6"], roomList["room7"]);
		createDoorUp (roomList["room6"], roomList["room22"]);

		createDoorRight (roomList["room8"], roomList["room9"]);

		createDoorForward (roomList["room9"], roomList["room13"]);
		createDoorUp (roomList["room9"], roomList["room25"]);

		createDoorRight (roomList["room10"], roomList["room11"]);
		createDoorForward(roomList["room10"], roomList["room14"]);

		createDoorForward(roomList["room11"], roomList["room15"]);

		createDoorRight(roomList["room12"], roomList["room13"]);

		createDoorRight(roomList["room14"], roomList["room15"]);

		createDoorUp(roomList["room15"], roomList["room31"]);

		//level 2
		createDoorForward(roomList["room16"], roomList["room20"]);

		createDoorRight(roomList["room17"], roomList["room18"]);

		createDoorUp(roomList["room18"], roomList["room34"]);

		createDoorUp(roomList["room19"], roomList["room35"]);
		createDoorForward(roomList["room19"], roomList["room23"]);

		createDoorRight (roomList["room20"], roomList["room21"]);
		createDoorForward(roomList["room20"], roomList["room24"]);

		createDoorUp(roomList["room21"], roomList["room37"]);

		createDoorRight (roomList["room22"], roomList["room23"]);
		createDoorForward(roomList["room22"], roomList["room26"]);

		createDoorForward(roomList["room23"], roomList["room27"]);

		createDoorForward(roomList["room24"], roomList["room28"]);

		createDoorForward(roomList["room25"], roomList["room29"]);

		createDoorForward(roomList["room26"], roomList["room30"]);

		createDoorUp(roomList["room28"], roomList["room44"]);

		createDoorRight (roomList["room29"], roomList["room30"]);

		createDoorRight (roomList["room30"], roomList["room31"]);

		//level 3
		createDoorForward(roomList["room32"], roomList["room36"]);

		createDoorRight (roomList["room33"], roomList["room34"]);
		createDoorUp (roomList["room33"], roomList["room49"]);

		createDoorForward (roomList["room35"], roomList["room39"]);
		createDoorUp (roomList["room35"], roomList["room51"]);

		createDoorRight (roomList["room36"], roomList["room37"]);
		createDoorUp (roomList["room36"], roomList["room52"]);

		createDoorForward (roomList["room37"], roomList["room41"]);

		createDoorForward (roomList["room38"], roomList["room42"]);
		createDoorUp (roomList["room38"], roomList["room54"]);

		createDoorUp(roomList["room39"], roomList["room43"]);

		createDoorRight (roomList["room40"], roomList["room41"]);

		createDoorUp (roomList["room41"], roomList["room45"]);

		createDoorRight (roomList["room42"], roomList["room43"]);

		createDoorForward (roomList["room43"], roomList["room47"]);

		createDoorRight (roomList["room45"], roomList["room46"]);
		createDoorUp (roomList["room45"], roomList["room61"]);

		createDoorUp (roomList["room47"], roomList["room63"]);

		//level 4
		createDoorForward (roomList["room48"], roomList["room52"]);

		createDoorForward (roomList["room49"], roomList["room53"]);
		createDoorRight (roomList["room49"], roomList["room50"]);

		createDoorRight (roomList["room50"], roomList["room51"]);

		createDoorRight (roomList["room52"], roomList["room53"]);

		createDoorForward (roomList["room54"], roomList["room58"]);

		createDoorForward (roomList["room55"], roomList["room59"]);

		createDoorForward (roomList["room56"], roomList["room60"]);
		createDoorRight (roomList["room56"], roomList["room57"]);

		createDoorForward (roomList["room57"], roomList["room61"]);

		createDoorRight (roomList["room58"], roomList["room59"]);

		createDoorRight (roomList["room62"], roomList["room63"]);
	}

	private static void createDoorUp(Room room1, Room room2){
		room1.setUp (room2);
		room2.setDown (room1);
	}

	private static void createDoorLeft(Room room1, Room room2){
		room1.setLeft (room2);
		room2.setRight (room1);
	}

	private static void createDoorRight(Room room1, Room room2){
		room1.setRight (room2);
		room2.setLeft (room1);	
	}

	private static void createDoorDown(Room room1, Room room2){
		room1.setDown (room2);
		room2.setUp (room1);	
	}

	private static void createDoorForward(Room room1, Room room2){
		room1.setForward (room2);
		room2.setBehind (room1);
	}

	private static void createDoorBehind(Room room1, Room room2){
		room1.setBehind (room2);
		room2.setForward (room1);	
	}




}
