using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Assessment1
{
    public class Player : MonoBehaviour
    {
        //Declare variables
        private Rigidbody2D rigid2D;
        public float jumpHeight;
        private bool canJump = true;
        public float movementSpeed;


        void Start()
        {
            //store rigidbody in variable
            rigid2D = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
            {
                //if player is allowed to jump, make them jump when input is pressed
                rigid2D.AddForce(Vector2.up * jumpHeight);
                canJump = false;
                //player cannot jump a second time
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                rigid2D.AddForce(Vector2.right * movementSpeed);
                //move player to the right
            }
            if (Input.GetKey(KeyCode.A))
            {
                rigid2D.velocity = rigid2D.velocity.normalized;
                //Stops all player movement
            }
        }

        public void OnCollisionEnter2D(Collision2D _col)
        {
            if (_col.gameObject.tag == "Ground")
            {
                canJump = true;
                //when player hits ground, allow them to jump
            }
            if (_col.gameObject.tag == "Enemy")
            {
                SceneManager.LoadScene(0);
                //if player hits enemy, restart level
            }
        }
    }
}