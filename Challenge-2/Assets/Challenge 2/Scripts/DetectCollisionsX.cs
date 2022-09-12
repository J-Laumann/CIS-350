/*
 * Jackson Laumann
 * Challenge 2
 * Destroys objects on collision and increases score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dog")
        {
            GameManager.instance.score++;
        }
        Destroy(gameObject);
    }
}
