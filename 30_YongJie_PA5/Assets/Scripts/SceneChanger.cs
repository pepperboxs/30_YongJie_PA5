using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GotoMainGame()
    {
        SceneManager.LoadScene("GamePlay_Level1");
    }
}
