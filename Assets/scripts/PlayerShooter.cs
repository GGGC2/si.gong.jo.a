using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour {

	public Gun con;
	public float speed = 1.0f;
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			Debug.Log("Shoot");
			con.Shoot();
		}
	}
}

