using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText;

    public void Update()
    {
        GameObject scoreManager = GameObject.Find("ScoreManagerObj");
        ScoreManager manager = scoreManager.GetComponent<ScoreManager>();

        float time = Mathf.Floor(manager.GetCurrentTime());
        string timeComputed = time.ToString().PadLeft(3, '0');

        timeText.text = "TIME\n" + timeComputed;
    }
}
