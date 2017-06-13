using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BronzeEnemyBullet : MonoBehaviour {

	public GameObject player;
	Vector3 deltaVec;
	Vector3 diff;
	float spd;
	float delta;

	void Start () {

		player = PlayerFinder.Instance.FindNearestPlayer(transform.position);

		if (player == null) {
			Destroy(gameObject);
		}

		spd = 10.0f;
		delta = spd * Time.deltaTime;
		diff = (player.transform.position - transform.position).normalized;
		deltaVec = diff * delta;
	}

	void Update () {
		delta = spd * Time.deltaTime;
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