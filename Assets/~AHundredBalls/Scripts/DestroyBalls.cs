using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AHundredBalls
{
    public class DestroyBalls : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D _col)
        {
            Destroy(_col.gameObject);
        }
    }
}