﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter2 : MonoBehaviour {

	public Gun2 con;
	public float speed = 1.0f;
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			Debug.Log("Shoot");
			con.Shoot();
		}
	}
}

