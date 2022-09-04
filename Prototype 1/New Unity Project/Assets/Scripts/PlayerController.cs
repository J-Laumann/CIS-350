/*
 * Jackson Laumann
 * Prototype 1
 * Controls the players movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed, turnSpeed;

    public float forwardInput, horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves forward with input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotate with horiz input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
