using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldEnemyBullet : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = PlayerFinder.Instance.FindNearestPlayer(transform.position);
		if (player == null) {
			Destroy(gameObject);
		}
    }

    void Update()
    {

        float delta = 5.0f * Time.deltaTime;
        Vector3 diff = (player.transform.position - transform.position).normalized;
        Vector3 deltaVec = diff * delta;
        transform.position = transform.position + deltaVec;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("player"))
        {
            Destroy(gameObject);
            other.SendMessage("hit");
        }
        if (other.gameObject.name.Contains("wall"))
        {
            Destroy(gameObject);
        }
    }
}