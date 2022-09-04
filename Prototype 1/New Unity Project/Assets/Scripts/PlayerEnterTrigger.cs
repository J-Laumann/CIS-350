/*
 * Jackson Laumann
 * Prototype 1
 * Increments score when hitting a trigger zone
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
            // To fix multiple scoring either destroy it or simply untag it
            Destroy(other.gameObject);
        }
    }
}
