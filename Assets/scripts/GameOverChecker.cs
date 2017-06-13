using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverChecker : MonoBehaviour
{

    public GameObject gameOverImage;

    // Update is called once per frame
    void Update()
    {
        if (PlayerFinder.Instance.player != null)
        {
            return;
        }

        if (PlayerFinder.Instance.player2 != null)
        {
            return;
        }

        Debug.Log("Player all dead");
        gameOverImage.SetActive(true);
    }
}
