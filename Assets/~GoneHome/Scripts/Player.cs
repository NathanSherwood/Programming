using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        private Rigidbody rb;
        public float movementSpeed;


        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            Vector3 position = transform.position;

            position += inputDir * movementSpeed * Time.deltaTime;

            rb.MovePosition(position);

            //           if (Input.GetKey(KeyCode.A))
            //           {
            //               rb.AddForce(Vector3.left * movementSpeed * Time.deltaTime, ForceMode.Impulse);
            //           }
            //           if (Input.GetKey(KeyCode.D))
            //           {
            //              rb.AddForce(Vector3.right * movementSpeed * Time.deltaTime, ForceMode.Impulse);
            //      }
            //         if (Input.GetKey(KeyCode.W))
            //         {
            //             rb.AddForce(Vector3.forward* movementSpeed * Time.deltaTime, ForceMode.Impulse);
            //         }
            //         if (Input.GetKey(KeyCode.S))
            //         {
            //             rb.AddForce(Vector3.back * movementSpeed * Time.deltaTime, ForceMode.Impulse);
            //         }
        }
    }
}
