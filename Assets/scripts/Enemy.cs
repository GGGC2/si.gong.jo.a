using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    public Transform target;
    private GameObject player;
    private GameObject enemy;
    private float range;
    public float Bronzespd;

    void Start() {
      //  enemy = GameObject.FindGameObjectWithTag ("Enemy");
        player = GameObject.FindGameObjectWithTag ("Player");
    }

    void Update() {
        if(player != null) {
            range = Vector2.Distance (transform.position, player.transform.position);
               if(range <= 5f) {
                    Debug.Log(transform.position);
                    Debug.Log(player.transform.position);
                    Debug.Log(Vector2.MoveTowards (transform.position, player.transform.position, range) );

                    Debug.Log(Vector2.MoveTowards (transform.position, player.transform.position, range) * Bronzespd * Time.deltaTime);
                  transform.position = Vector3.MoveTowards (transform.position, player.transform.position, range * Bronzespd * Time.deltaTime) ;
               }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("enemy trigger");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("enemy collision");
    }
}
