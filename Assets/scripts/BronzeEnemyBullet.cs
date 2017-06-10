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
			          var player1 = GameObject.FindGameObjectWithTag ("Player");
        var player2 = GameObject.FindGameObjectWithTag("Player2");

        if (player == null && player2 == null) {

        }
        else if (player== null) {
            player = player1;
        }
        else if (player2 == null) {
       player = player2;
        }
        else {
            var range1 = Vector2.Distance (transform.position, player.transform.position);
        
            var range2 = Vector2.Distance (transform.position, player2.transform.position);

            if (range1 <= range2) {
player = player1;
            } else {
player = player2;
            }
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