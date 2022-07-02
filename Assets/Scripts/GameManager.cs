using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.UI;

using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    private static int scoreData;
    public TextMeshProUGUI scoreText;




    void Start()
    {
        score = 0;
        scoreData = PlayerPrefs.GetInt("scoreData");
        scoreText.text = "Score: "+ scoreData.ToString();
        score = scoreData;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameScore(int ringScore)
    {
        score += ringScore;
        PlayerPrefs.SetInt("scoreData", score);
        if (score < 0)
        {
            score = 0;
        }
        scoreText.text = "Score: " + score.ToString();
        
    }

     

}
