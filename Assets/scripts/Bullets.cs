using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour {
	Enemy e;
	public LayerMask collisionMask;
	public float spd = 10; // 총탄이 나가는 속도 설정
	public void SetSpd(float newSpd) {
		spd = newSpd;
	}
	void Update () {
		float moveDistance = spd * Time.deltaTime; 
		transform.Translate (Vector3.up * moveDistance);

		


	} //총알 발사
	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log("OnTriggerEnter");

		if(col.gameObject.name.Contains( "wall")){
			Destroy(gameObject);
		}
		if (col.gameObject.name.Contains("Enemy")) {
			Destroy(gameObject);
			col.SendMessage("ehit");
		}
	}
}
