using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearChecker : MonoBehaviour
{

	public GameObject winImage;

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.name.Contains("player"))
        {
            return;
        }

        ClearCheck();
    }

    /// <summary>
    /// OnTriggerStay is called once per frame for every Collider other
    /// that is touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerStay(Collider other)
    {
        if (!other.name.Contains("player"))
        {
            return;
        }

        ClearCheck();
    }

    private void ClearCheck()
    {
        var enemies = FindObjectsOfType<Enemy>();
        if (enemies.Length == 0)
        {
			winImage.SetActive(true);
            Debug.Log("Clear ");
        }
        else
        {
            Debug.Log("Enemy remains " + enemies.Length);
        }
    }
}
