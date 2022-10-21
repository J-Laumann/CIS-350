/*
 * Jackson Laumann
 * Prototype 3
 * Moves this to the left constantly
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30f;
    private float leftBound = -15f;

    private PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
