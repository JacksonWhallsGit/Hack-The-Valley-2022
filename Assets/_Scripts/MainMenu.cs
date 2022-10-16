using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static MainMenu mainMenuInstance;
    [SerializeField]
    private TMP_InputField userNameInput;

    public void StartGame()
    {
        userNameInput = gameObject.GetComponent<TMP_InputField>();
        SceneManager.LoadScene("SampleScene");

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SaveUserName()
    {
        PlayerPrefs.SetString("userName", userNameInput.text);
    }

}
