﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM : MonoBehaviour
{
    public Animator animator;
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 3f;
    public bool isLanding = false;
    Vector3 velocity;

    private bool isGrounded;
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;

        }


        if (Input.GetButtonDown("Jump") && isGrounded)
        {

            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        }
        // animations for jumping
        if (isGrounded == true)
        {

            animator.SetBool("jump", false);
            isLanding = false;
        }
        else
        {
            animator.SetBool("jump", true);
            isLanding = true;
        }

        if (isLanding)
        {
            animator.SetBool("jumpEnd", true);
        }
        else
        {
            animator.SetBool("jumpEnd", false);
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        animator.SetFloat("horizontal", x);
        animator.SetFloat("vertical", z);

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
