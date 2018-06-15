using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Breakout
{
    public class Destroy : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.tag == "Block")
            {
                Destroy(coll.gameObject);
                Score.scoreCount++;
            }
        }
    }
}