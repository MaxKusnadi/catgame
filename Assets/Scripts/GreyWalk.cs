﻿using UnityEngine;
using System.Collections;

public class GreyWalk : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public Vector2 speed = new Vector2(50, 50);

	
	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);

    }
}
