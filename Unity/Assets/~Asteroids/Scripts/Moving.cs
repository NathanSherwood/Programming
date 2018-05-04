using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{

    public class Moving : MonoBehaviour
    {
        public float movementSpeed = 10f;
        public float rotateSpeed = 360f;


        void Start()
        {

        }

        void Movement()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
            }
        }

        void Rotation()
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
            }
        }

        void Update()
        {
            Movement();
            Rotation();
        }
    }
}