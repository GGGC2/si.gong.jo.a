using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove2 : MonoBehaviour {

	public float speed = 1.0f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float delta = speed * Time.deltaTime;
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position = new Vector3(transform.position.x, transform.position.y + delta, transform.position.z);
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position = new Vector3(transform.position.x - delta, transform.position.y, transform.position.z);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position = new Vector3(transform.position.x, transform.position.y - delta, transform.position.z);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position = new Vector3(transform.position.x + delta, transform.position.y, transform.position.z);
		}
	}
}
