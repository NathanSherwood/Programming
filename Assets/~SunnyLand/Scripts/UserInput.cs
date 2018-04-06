using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunnyLand
{
    [RequireComponent(typeof(PlayerController))]
    public class UserInput : MonoBehaviour
    {
        public bool isJumping = false;
        public bool isCrouching = false;
        public float inputH, inputV;

        private PlayerController player;

        #region Unity Functions
        void Start()
        {
            player = GetComponent<PlayerController>();
        }

        void Update()
        {
            GetInput();
            player.Move(inputH);
            player.Climb(inputV);
            if (isJumping)
            {
                player.Jump();
            }
            if (isCrouching)
            {
                player.Crouch();
            }
            else
            {
                player.UnCrouch();
            }
        }
        #endregion

        #region Custom Functions
        void GetInput()
        {
            inputH = Input.GetAxisRaw("Horizontal");
            inputV = Input.GetAxisRaw("Vertical");
            isJumping = Input.GetKeyDown(KeyCode.Space);
            isCrouching = Input.GetKey(KeyCode.LeftControl);
        }
        #endregion
    }
}