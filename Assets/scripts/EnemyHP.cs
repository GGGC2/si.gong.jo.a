using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {


	public int ehp = 5; //ehp = enemyhp
	void Start () {
		
	}
	

	void Update () {
		
		}


	void ehit() {

		ehp = ehp - 1;

		if(ehp < 1) {
		Destroy(gameObject);
			}
		}

}

