using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;

    public void Update()
    {
        GameObject scoreManager = GameObject.Find("ScoreManagerObj");
        ScoreManager manager = scoreManager.GetComponent<ScoreManager>();

        int score = manager.GetScore();
        string scoreComputed = score.ToString().PadLeft(6, '0');

        scoreText.text = "MARIO \n" + scoreComputed;
    }
}
