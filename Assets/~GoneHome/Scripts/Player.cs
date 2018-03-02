using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        private Rigidbody rb;
        public float acceleration = 10f;
        public float maxVelocity = 10f;
        


        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            //Transform cam = Camera.main.transform;
            Vector3 inputDir = new Vector3(inputH, 0, inputV);
           // inputDir = Quaternion.AngleAxis(cam.eulerAngles.y, Vector3.up) * inputDir;

            rb.AddForce(inputDir * acceleration);

            float velY = rb.velocity.y;

            Vector3 vel = rb.velocity;

            if (vel.magnitude > maxVelocity)
            {
                vel = vel.normalized * maxVelocity;
            }

            

           if (inputH == 0 && inputV == 0)
            {
                vel = vel.normalized * 0;
            }

            rb.velocity = new Vector3(vel.x, velY, vel.z);
            
        }
    }
}
