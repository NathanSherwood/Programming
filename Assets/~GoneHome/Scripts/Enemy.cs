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

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }

        void Update()
        {
            agent.SetDestination(target.position);
        }
    }
}