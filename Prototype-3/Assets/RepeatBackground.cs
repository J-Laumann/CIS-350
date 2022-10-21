/*
 * Jackson Laumann
 * Prototype 3
 * Resets the background
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;

    private void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 2;
    }

    private void Update()
    {
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
