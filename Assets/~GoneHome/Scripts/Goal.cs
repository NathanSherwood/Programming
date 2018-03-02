using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GoneHome
{
    public class Goal : MonoBehaviour
    {
        public UnityEvent onTriggered;

        void OnTriggerEnter(Collider other)
        {
            if (other.name == "Player")
            {
      //          GameObject.FindGameObjectWithTag("GameManager").GetComponent<>;
                onTriggered.Invoke();
                
            }
        }

    }
}