using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AHundredBalls
{
    public class Bucket : MonoBehaviour
    {
        public float speed = 10f;
        public Rigidbody2D rigid2D;
        public Renderer[] renderers;
        public Vector2 direction = Vector2.right;

        void Start()
        {
            rigid2D = GetComponent<Rigidbody2D>();
            renderers = GetComponentsInChildren<Renderer>();
        }

        void Update()
        {
            HandlePosition();
            HandleBoundary();
           // transform.position += (Vector3)direction * speed * Time.deltaTime;
        }
        void HandlePosition()
        {
            rigid2D.velocity = Vector3.left * speed;
        }
        void HandleBoundary()
        {
            Vector3 transformPos = transform.position;
            Vector3 viewportPos = Camera.main.WorldToViewportPoint(transformPos);
            if(IsVisible() == false && viewportPos.x < 0)
            {
                Destroy(gameObject);
            }
        }
        bool IsVisible()
        {
            foreach(var renderer in renderers)
            {
                if(renderer.isVisible)
                {
                    return true;
                }
            }
            return false;
        }
    }
}