/*
 * Jackson Laumann
 * Prototype 3
 * Controls the player movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode jumpForceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if(Physics.gravity.y > -10)
            Physics.gravity *= gravityModifier;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!gameOver)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isOnGround = true;
            }
            else if (collision.gameObject.CompareTag("Obstacle"))
            {
                gameOver = true;
            }
        }
    }
}
