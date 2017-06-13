using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFinder : MonoBehaviour {

	public GameObject player;
	public GameObject player2;

	public static PlayerFinder Instance;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		Instance = this;
	}

	public GameObject FindNearestPlayer(Vector3 position, float range) {
		GameObject nearest = FindNearestPlayer(position);
        var nearestRange = Vector2.Distance(position, nearest.transform.position);
		if (nearestRange > range) {
			return null;
		}
		return nearest;
	}

	public GameObject FindNearestPlayer(Vector3 position) {
		if (player == null && player2 == null) {
			return null;
		}

		if (player == null) {
			return player2;
		}

		if (player2 == null) {
			return player;
		}

        var range1 = Vector2.Distance(position, player.transform.position);
        var range2 = Vector2.Distance(position, player2.transform.position);

		if (range1 < range2) {
			return player;
		} else {
			return player2;
		}
	}
}
