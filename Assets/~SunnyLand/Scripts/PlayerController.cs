﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunnyLand
{
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        #region Variables

        public float speed = 5;
        public int health = 100;
        public int damage = 50;
        [Tooltip("The maximum speed a player can move")]
        public float maxVelocity = 5f;
        public float maxSlopeAngle = 45f;
        [Header("Grounding")]
        public float rayDistance = .25f;
        public bool isGrounded = false;
        public bool isOnSlope = false;
        [Header("Crouch")]
        public bool isCrouching = false;
        public float jumpHeight = 2f;
        public int maxJumpCount = 2;
        public bool isJumping = false;
        [Header("Climb")]
        public float climbSpeed = 5f;
        public bool isClimbing = false;

        private Vector3 groundNormal = Vector3.up;
        private int currentJump = 0;
        private float inputH, inputV;

        //References
        private SpriteRenderer rend;
        private Rigidbody2D rigid;

        #endregion

        #region Unity Functions
        void Awake()
        {
            rend = GetComponent<SpriteRenderer>();
            rigid = GetComponent<Rigidbody2D>();
        }
        void Update()
        {
            PerformClimb();
            PerformJump();
            PerformMove();
        }
        void FixedUpdate()
        {

        }
        void OnDrawGizmos()
        {

        }
        #endregion

        #region Custom Functions
        public void Jump()
        {

        }
        public void Crouch()
        {

        }
        public void UnCrouch()
        {

        }
        public void Move(float horizontal)
        {
            if (horizontal != 0)
            {
                rend.flipX = horizontal < 0;
            }
            inputH = horizontal;
        }
        public void Climb(float vertical)
        {

        }
        public void Hurt(int damage)
        {

        }
        //Actions
        void PerformMove()
        {
            Vector3 right = Vector3.Cross(groundNormal, Vector3.forward);
            rigid.AddForce(right * inputH * speed);
            LimitVelocity();
        }
        void PerformClimb()
        {

        }
        void PerformJump()
        {

        }
        //Detectors
        void DetectClimbable()
        {

        }
        void DetectGround()
        {

        }
        void CheckGround(RaycastHit2D hit)
        {

        }
        void CheckEnemy(RaycastHit2D hit)
        {

        }
        //Helpers
        void LimitVelocity()
        {
            Vector3 vel = rigid.velocity;
            if (vel.magnitude > maxVelocity)
            {
                vel = vel.normalized * maxVelocity;
            }
        }
        void StopClimbing()
        {

        }
        void EnablePhysics()
        {

        }
        void DisablePhysics()
        {

        }
        #endregion
    }
}