using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    [SerializeField] private GameObject endScreen;

    private void Awake()
    {
        endScreen.SetActive(false);
   
    }

    public void EndGame()
    {
        endScreen.SetActive(true);
        StopWatch.stopWatchInstance.StopTheStopWatch();
    }


    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
