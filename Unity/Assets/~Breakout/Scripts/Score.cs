using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int scoreCount = 0;
    public static int lives = 3;
    public Text scoreText;
    public Text livesText;

	void Update ()
    {
        scoreText.text = "Score: " + scoreCount.ToString();
        livesText.text = "Lives: " + lives.ToString();
        if (lives < 0)
        {
            SceneManager.LoadScene(5);
            lives = 3;
            scoreCount = 0;
        }
    }
}