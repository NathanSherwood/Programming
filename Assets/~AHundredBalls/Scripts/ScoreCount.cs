using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AHundredBalls
{
    public class ScoreCount : MonoBehaviour
    {
        public static int score;

        void OnTriggerEnter2D(Collider2D _col)
        {
            if (_col.gameObject.tag == "Ball")
            {
                score++;
            }
        }
    }
}