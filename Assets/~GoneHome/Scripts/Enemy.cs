using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

namespace GoneHome
{
    public class Enemy : MonoBehaviour
    {
        public Transform target;
        private NavMeshAgent agent;
        private Vector3 spawnPoint;

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            target = GameObject.FindGameObjectWithTag("Player").transform;
            spawnPoint = transform.position;
        }

        void Update()
        {
            agent.SetDestination(target.position);
        }
        public void Reset()
        {
            transform.position = spawnPoint;
        }
    }
}