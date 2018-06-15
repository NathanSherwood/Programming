using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartBall : MonoBehaviour
{
    public Transform paddle;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Death")
        {
            Debug.Log("entered");
            rb.velocity = Vector3.zero;
            this.transform.SetParent(paddle);
        }
    }
}
