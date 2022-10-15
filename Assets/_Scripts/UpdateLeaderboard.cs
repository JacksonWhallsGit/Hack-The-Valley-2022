using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;

public class UpdateLeaderboard : MonoBehaviour
{
    public static List<(TimeSpan, string)> leaderboardEntry = new List<(TimeSpan, string)>();


    public TextMeshProUGUI firstLaderboardScoreText;
    public TextMeshProUGUI firstNameText;

    public TextMeshProUGUI secondLeaderboardScoreText;
    public TextMeshProUGUI secondNameText;

    public TextMeshProUGUI thirdLeaderboardScoreText;
    public TextMeshProUGUI thirdNameText;

    // Start is called before the first frame update
    void Start()
    {
        leaderboardEntry.Sort(Comparer<(TimeSpan, string)>.Default);

        if (leaderboardEntry.Count == 1)
        {
            firstNameText.text = leaderboardEntry[0].Item2;
            firstLaderboardScoreText.text = leaderboardEntry[0].Item1.ToString(@"mm\:ss\:ff");
        }
        if (leaderboardEntry.Count == 2)
        {

            firstNameText.text = leaderboardEntry[0].Item2;
            firstLaderboardScoreText.text = leaderboardEntry[0].Item1.ToString(@"mm\:ss\:ff");
            secondNameText.text = leaderboardEntry[1].Item2;
            secondLeaderboardScoreText.text = leaderboardEntry[1].Item1.ToString(@"mm\:ss\:ff");
        }
        if (leaderboardEntry.Count >= 3)
        {

            firstNameText.text = leaderboardEntry[0].Item2;
            firstLaderboardScoreText.text = leaderboardEntry[0].Item1.ToString(@"mm\:ss\:ff");
            secondNameText.text = leaderboardEntry[1].Item2;
            secondLeaderboardScoreText.text = leaderboardEntry[1].Item1.ToString(@"mm\:ss\:ff");
            thirdNameText.text = leaderboardEntry[2].Item2;
            thirdLeaderboardScoreText.text = leaderboardEntry[2].Item1.ToString(@"mm\:ss\:ff");
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
