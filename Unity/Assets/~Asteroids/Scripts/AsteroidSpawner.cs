using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{
    public class AsteroidSpawner : MonoBehaviour
    {
        public GameObject[] asteroidPrefabs;
        public float spawnRate = 1f;
        public float spawnRadius = 3f;

        // Use this for initialization
        void Start()
        {
            InvokeRepeating("Spawn", 0, spawnRate);
        }

        // Update is called once per frame
        void Update()
        {

        }
        void Spawn()
        {
            Vector3 rand = Random.insideUnitSphere * spawnRadius;

            rand.z = 0f;

            Vector3 position = transform.position + rand;

            int randIndex = Random.Range(0, asteroidPrefabs.Length);

            GameObject randAsteroid = asteroidPrefabs[randIndex];

            GameObject clone = Instantiate(randAsteroid);

            clone.transform.position = position;

            Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();

            Vector3 randomDirection = new Vector2(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

            float randomSpeed = Random.Range(0.1f, 2.0f);

            rigid.AddForce(randomDirection * randomSpeed, ForceMode2D.Impulse);
        }
    }
}
