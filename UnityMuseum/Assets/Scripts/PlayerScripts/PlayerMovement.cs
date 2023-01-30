using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    //Variables that can be changed via inspector console
    public float speed = 12f;
    public static float gravity;
    public float jumpHeight = 3f;
    public float pushPower = 2.0f;

    //Variables for checking if the player is on the ground
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    //Velocity variable
    Vector3 velocity;

    private void Start()
    {
        gravity = -9.81f;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if player is on the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //If player is on the ground, stop their Y axis velocity
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    //Pushes Rigidbodies the player touches
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        //If player is not touching a Ridig body or the object they are touching is Kinematic, do nothing
        if (body == null || body.isKinematic)
        {
            return;
        }

        //If the object is below the player, do nothing
        if (hit.moveDirection.y < -0.3)
        {
            return;
        }

        //Calculates the direction the object should move based on where the player is moving. Also makes sure the object can only move on the X and Z axis
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        //Pushes the object based on the power, direction and the player velocity
        body.velocity = pushDir * pushPower;
    }
}
