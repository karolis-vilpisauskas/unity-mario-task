using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    public Text coinText;

    public void Update()
    {
        GameObject scoreManager = GameObject.Find("ScoreManagerObj");
        ScoreManager manager = scoreManager.GetComponent<ScoreManager>();

        int coins = manager.GetCoins();
        string coinsComputed = coins.ToString().PadLeft(2, '0');

        coinText.text = "\n" + coinsComputed;
    }
}
