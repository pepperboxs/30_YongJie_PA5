using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float Score;
    public Text ScoreText;
    private int level = 1;

    private void Start()
    {
        level++;
    }
    void Update()
    {
        if (Score >= 4)
        {
            YouWin();
        }
    }

    public void AddScore()
    {
        Score++;
        ScoreText.text = "Coins Collected = " + Score;
    }

    void YouWin()
    {
        if (Score == 4)
        {
            if (level == 1)
            {
                ScoreText.text = "You Win!";
                SceneManager.LoadScene("GamePlay_Level2");
                level++;
            }
            else if (level == 2)
            {
                SceneManager.LoadScene("YouWin");
            }
        }
    }

    public void YouLose()
    {
        SceneManager.LoadScene("GameLose");
    }

}
