using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace AHundredBalls
{
    public class ScoreTracker : MonoBehaviour
    {
        public Text scoreText;

        void Update()
        {
            scoreText.text = "Score: " + ScoreCount.score.ToString();
        }
    }
}
