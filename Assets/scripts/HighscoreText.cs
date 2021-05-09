using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HighscoreText : MonoBehaviour
{
    Text highscore;

    //void Start()
    //{
    //    highscore = GetComponent<Text>();
    //    highscore.text = "High score: " + PlayerPrefs.GetInt("HighScore").ToString();
    //}
    private void Update()
    {
        highscore = GetComponent<Text>();
        highscore.text = "High score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
