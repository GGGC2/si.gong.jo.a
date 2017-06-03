using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {


	void Start () {
		
	}

	void Update () {

		float delta = 1.0f * Time.deltaTime;

		transform.position = new Vector3(transform.position.x + delta, transform.position.y, transform.position.z);
	}
}
