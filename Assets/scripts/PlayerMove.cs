using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public float speed = 1.0f;


	void Start () {
		
	}
	

	void Update () {
		float delta = speed * Time.deltaTime;
		// transform.position = new Vector3(transform.position.x, transform.position.y + delta, transform.position.z);
		if (Input.GetKeyDown("w"))
		{
			Debug.Log("awefaeaw");
			transform.position = new Vector3(transform.position.x, transform.position.y + delta, transform.position.z);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position = new Vector3(transform.position.x - delta, transform.position.y, transform.position.z);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position = new Vector3(transform.position.x, transform.position.y - delta, transform.position.z);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.position = new Vector3(transform.position.x + delta, transform.position.y, transform.position.z);
		}
	}
}
