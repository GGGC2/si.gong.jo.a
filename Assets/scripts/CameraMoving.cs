using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour {
	public GameObject player;
	public GameObject player2;
	private Vector3 offset;
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		player2 = GameObject.FindGameObjectWithTag("Player2");
		//offset = transform.position - (player.transform.position + player2.transform.position)/2;
	}
	
	void LateUpdate () {
		transform.position = (player.transform.position + player2.transform.position) * 0.5f;
		transform.position = new Vector3(transform.position.x, transform.position.y, -10 );
	//	transform.position = player.transform.position + offset;
	}
}
