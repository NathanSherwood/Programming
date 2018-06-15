using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assessment1
{
    public class CameraScript : MonoBehaviour
    {
        public Transform player;
        public float offset = 8f;

        //slightly lags behind player
        void FixedUpdate()
        {
            //follows players position but keeps level in view with offset
            transform.position = new Vector3(player.position.x + offset, transform.position.y, transform.position.z);
        }
    }
}