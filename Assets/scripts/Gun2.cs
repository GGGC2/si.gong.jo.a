using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour {
	public Bullets b;
	public float msBetweenShots = 100; //연사속도
	public float muzzleVel = 35; //총구속도 

	float nextShotTime;

	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
        if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.eulerAngles = Vector3.one;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.eulerAngles = new Vector3(0, 0, 90);
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.eulerAngles = new Vector3(0, 0, 180);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.eulerAngles = new Vector3(0, 0, 270);
		}
	}

	public void Shoot() {

		if (Time.time > nextShotTime) {
			nextShotTime = Time.time + msBetweenShots / 1000;
			Bullets newB = Instantiate (b, transform.position, transform.rotation) as Bullets;
			newB.SetSpd (muzzleVel);
		}
	}
}
