using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BronzeEnemyBullet : MonoBehaviour {


	void Start () {
		
	}

	void Update () {

		float delta = 1.0f * Time.deltaTime;

		Vector3 deltaVec = transform.right * delta;
		transform.position = transform.position + deltaVec;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name.Contains("player")) {
			Destroy(gameObject);
			other.SendMessage("hit");
		}
		if(other.gameObject.name.Contains("wall")){
			Destroy(gameObject);
		}
	}
}