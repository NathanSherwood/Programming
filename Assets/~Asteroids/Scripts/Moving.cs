using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clean Code: CTRL + K + D (in that order)

// {} - Braces
// [] - Brackets
// () - Parenthesis
namespace Asteroids
{
    public class Moving : MonoBehaviour
    {
        // Member Variables
        public float rotationSpeed;
        public float movementSpeed;
        private Rigidbody2D rigid;

        void Movement()
        {
            // Move up
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            }

            // Move down
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
            }
        }

        void Rotation()
        {
            // Rotate Right
            if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }
        }



        void Update()
        {
            // Call 'Movement()' function
            Movement();

            // Call 'Rotation()' function
            Rotation();
        }
    }
}
