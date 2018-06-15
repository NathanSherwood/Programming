using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{
    public class Destroy : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D _col)
        {
            if (_col.gameObject.tag != "Player")
            {
                Destroy(_col.gameObject);
            }
        }
    }
}