using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    // Use this for initialization
    void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel("Room Page");
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
