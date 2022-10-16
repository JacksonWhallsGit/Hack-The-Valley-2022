using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 12f;
    public float strafeSpeed = 17f;
    public float jumpForce = 12f;

    private float jumpBufferTime = 0.4f;
    private Boolean jumpIsBuffered = false;
    private Animator animator;

    private Rigidbody rb;

    private Boolean isJumping = false;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheckPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpIsBuffered)
        {
            jumpBufferTime -= Time.deltaTime;
        }
        if (!IsGrounded())
        {
            isJumping = true;
            animator.SetBool("isJumping", true);
        }
        else
        {
            Physics.gravity = new Vector3(0, -20f, 0);
            isJumping = false;
            animator.SetBool("isJumping", false);
        }

        if(isJumping && rb.velocity.y < 0)
        {
            Physics.gravity = new Vector3(0, -50f, 0);   
        }

        if (((Input.GetKeyDown(KeyCode.Space) || (jumpBufferTime > 0 && jumpBufferTime < 0.4f)) && IsGrounded()))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            jumpBufferTime = 0.4f;
            jumpIsBuffered = false;
        } else if(Input.GetKeyDown(KeyCode.Space) && !IsGrounded())
        {
            jumpIsBuffered = true;
        }
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(horizontalInput * strafeSpeed, rb.velocity.y, moveSpeed);
    }

    Boolean IsGrounded()
    {
        return Physics.CheckSphere(groundCheckPoint.position, 0.1f, groundLayer);
    }

}
