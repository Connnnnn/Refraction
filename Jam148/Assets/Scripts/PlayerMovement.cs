using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    private float lastJumpTime = 0f;


    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        //Had an isGrounded Check here before but the boolean subtraction by probuilder destroyed the mask
        if (Input.GetButtonDown("Jump") && lastJumpTime + 1f <= Time.time && gameObject.transform.position.y < 8)
        {
            lastJumpTime = Time.time;
            velocity.y = Mathf.Sqrt(jumpHeight*-2*gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        /*
        if (isGrounded)
        {
            Debug.Log("IS GROUNDED");
        }
        else {
            Debug.Log("IS NOT GROUNDED");
        }

    */

    }
}
