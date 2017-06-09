using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour {

	public GameObject enemybullet;
	public float cooltime = 3;


	void Start () {
		cooltime = 0.5f;
	}
	

	void Update () {
		
		cooltime = cooltime - Time.deltaTime;

		if (cooltime < 0)
		{
			Instantiate(enemybullet, transform.position, transform.rotation);
			cooltime = 3;
		}
	}
}
