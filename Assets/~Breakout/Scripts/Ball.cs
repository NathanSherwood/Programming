using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Ball : MonoBehaviour
    {
        public float speed = 5.0f;
        public Transform paddle;
        private Vector3 velocity;

        private Quaternion originalRotation;
        public Vector3 originalPosition;

        void Start()
        {
            originalPosition = transform.localPosition;
            originalRotation = transform.localRotation;
        }
        public void Fire(Vector3 direction)
        {
            velocity = direction * speed;
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            ContactPoint2D contact = collision.contacts[0];

            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);
            
            velocity = reflect.normalized * velocity.magnitude;
        }

        void Update()
        {
            transform.position += velocity * Time.deltaTime;
        }


        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.tag == "Death")
            {
                velocity = Vector3.zero;
                this.transform.SetParent(paddle);
                transform.localPosition = originalPosition;
                transform.rotation = originalRotation;
                paddle.gameObject.GetComponent<Paddle>().holdingBall = true;
                Score.lives--;
            }
        }
    }
}