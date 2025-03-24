using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        UpdateHighScoreText();
    }

    void UpdateHighScoreText()
    {
        if (DataManager.Instance != null)
        {
            highScore.text = "Best Score: " + DataManager.Instance.highScore + " Name: " + DataManager.Instance.highScorePlayerName;
        }
        else
        {
            highScore.text = "Best Score: 0";
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
