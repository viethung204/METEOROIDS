using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scored : MonoBehaviour
{
    public int Score = 0;
    public TextMeshProUGUI scoreText;


    // Update is called once per frame
    void Update()
    {
        scoreText.text = Score.ToString("00");
    }

    public void METDestroyed(int score)
    {
        Score += score;
    }
}
