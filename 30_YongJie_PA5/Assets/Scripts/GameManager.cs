using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float Score;
    public Text ScoreText;

    void Update()
    {
        if (Score >= 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void AddScore()
    {
        Score++;
        ScoreText.text = "Coins Collected = " + Score;
    }

    public void YouLose()
    {
        SceneManager.LoadScene("GameLose");
    }

}
