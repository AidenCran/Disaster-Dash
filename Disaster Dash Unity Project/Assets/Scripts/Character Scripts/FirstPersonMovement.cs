using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using Cycle2AidensWork;

namespace Cycle2AidensWork
{
    /// <summary>
    /// Author: Aiden Cran
    /// Date:
    /// Last Edited:
    /// 
    /// 
    /// </summary>
    public class FirstPersonMovement : MonoBehaviour
    {
        public float gravity = -9.81f;

        public Transform groundCheck;
        public LayerMask groundMask;
        public LayerMask waterMask;
        public CharacterController controller;

        float speed = 15;
        float groundDistance = 0.4f;
        float jumpHeight = 1.5f;

        bool isGrounded;
        bool inWater;

        Vector3 velocity;
        

        private void Update()
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            inWater = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -1f;
            }

            if (!inWater)
            {
                //onTouchWater.instance.ResetCoroutine();
            }

            playerMovement();
        }

        public void playerMovement()
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);

            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                Jump();
                PlayerPrefs.SetInt("jumps", PlayerPrefs.GetInt("jumps") + 1);
            }
        }

        public void Jump()
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
}
