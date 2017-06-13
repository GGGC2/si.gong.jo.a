using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target;
    private GameObject enemy;
    public float Bronzespd;

    void Start()
    {
    }

    void Update()
    {
        float range = 5.0f;
        var nearPlayer = PlayerFinder.Instance.FindNearestPlayer(transform.position, range);

        if (nearPlayer == null)
        {

        }
        else
        {
            FollowPlayer(nearPlayer);
        }
    }

    void FollowPlayer(GameObject player)
    {
        float range = Vector2.Distance(transform.position, player.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, range * Bronzespd * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // Debug.Log("enemy trigger");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("enemy collision");
    }
}
