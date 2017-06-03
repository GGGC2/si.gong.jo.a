using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	public Bullets b;
	public float msBetweenShots = 100; //연사속도
	public float muzzleVel = 35; //총구속도 

	float nextShotTime;

	public void Shoot() {

		if (Time.time > nextShotTime) {
			nextShotTime = Time.time + msBetweenShots / 1000;
			Bullets newB = Instantiate (b, transform.position, transform.rotation) as Bullets;
			newB.SetSpd (muzzleVel);
		}
	}
}
