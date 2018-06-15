using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assessment1
{
    public class Spawning : MonoBehaviour
    {
        public Vector2 origin;
        public Vector2 rayDirection = Vector2.down;
        public float rayDistance = 20f;
        public GameObject[] walls;
        public GameObject ground;
        public float xOffset = 16.5f;

        void Start()
        {
            //assign variables
            walls = GameObject.FindGameObjectsWithTag("Wall");
            ground = GameObject.FindGameObjectWithTag("GroundEmpty");
        }

        public void FixedUpdate()
        {
            RayCasting();
        }
        private void RayCasting()
        {
            //changes origin point before shooting ray each frame
            origin = transform.position;

            //shoots ray
            RaycastHit2D hit = Physics2D.Raycast(origin, rayDirection * rayDistance);

            if (hit.collider == null)
            {
                //if no ground is found, spawn more ground
                Spawn();
            }
            //Draws ray for debug purposes
            Debug.DrawRay(origin, rayDirection * rayDistance);
        }

        public void Spawn()
        {
            //set the spawnpoint of the ground 
            Vector3 spawnPoint = new Vector3(Mathf.Round(transform.position.x), 0, 0);

            //spawn the ground
            Instantiate(ground, spawnPoint, Quaternion.identity);

            //loops for length of array spawning walls at intervals across the ground
            for (int i = 0; i < walls.Length; i++)
            {
                //set position of spawn and offset every iteration
                spawnPoint = new Vector3(spawnPoint.x + xOffset, 0, 0);

                //spawn a random wall from the array
                Instantiate(walls[Random.Range(0, walls.Length)], spawnPoint, Quaternion.identity);
            }
        }
    }
}