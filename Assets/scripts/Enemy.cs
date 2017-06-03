using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("OnTriggerEnter");
        if (col.gameObject.name == "Enemy")
        {
            Destroy(col.gameObject);
            Debug.Log("Destroy");
        }
    }
}
