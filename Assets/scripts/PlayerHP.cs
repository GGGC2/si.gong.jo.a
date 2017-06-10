using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour {


	public int hp = 3;
	void Start () {
		
	}
	

	void Update () {
		
		}


	void hit() {

		hp = hp - 1;

		if(hp < 1) {
		Destroy(gameObject);
			}
		}

}
