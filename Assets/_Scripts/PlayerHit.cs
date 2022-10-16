using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{

    private GameOver gameOverManager;

    private void Awake()
    {
        gameOverManager = FindObjectOfType<GameOver>();
    }

    private void OnTriggerEnter(Collider other)
	{
		if (other.name == "Y Bot")
		{
			Debug.Log("hit");
            Time.timeScale = 0f;
            gameOverManager.EndGame();
            StopWatch.stopWatchInstance.SaveTime();
        }
	}
}
