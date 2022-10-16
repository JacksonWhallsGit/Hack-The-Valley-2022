using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StopWatch : MonoBehaviour
{
    public static StopWatch stopWatchInstance;


    [SerializeField] private TextMeshProUGUI stopWatchText;
    private float stopWatchDisp;
    private bool startCounting;
    TimeSpan timeSpan;

    private void Awake()
    {
        stopWatchInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        startCounting = true;
        stopWatchDisp = 0;
    }

    void Update()
    {
        IncrementStopWatch();
    }

    public void StartTheStopWatch()
    {
        startCounting = true;
    }

    public void StopTheStopWatch()
    {
        startCounting = false;
    }


    public void IncrementStopWatch()
    {
        if (startCounting == true)
        {
            stopWatchDisp += Time.deltaTime;
            timeSpan = TimeSpan.FromSeconds(stopWatchDisp);
            stopWatchText.text = timeSpan.ToString(@"mm\:ss\:ff");

        }

    }

    public void SaveTime()
    {
        PlayerPrefs.SetString("stopWatchText", stopWatchText.text);
        UpdateLeaderboard.leaderboardEntry.Add((timeSpan, PlayerPrefs.GetString("userName")));
    }


}
