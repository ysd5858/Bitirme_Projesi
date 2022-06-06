using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public int Score;

    public Text ScoreText;
    public int maxScore;

    void Start()
    {
        Score = 0;
        ScoreText.text = Score.ToString();
    }

    
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
        if(PlayerPrefs.GetInt("maxscor")<Score)
        {
            maxScore = Score;
            PlayerPrefs.SetInt("maxscor", maxScore);
        }
    }

    public void RestartGame()
        {
        SceneManager.LoadScene(0);
        }
}
