using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour {

	public GameObject enemybullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.Space))
		{
			Debug.Log("space");
			Instantiate(enemybullet, transform.position, transform.rotation);
		}

	}
}
