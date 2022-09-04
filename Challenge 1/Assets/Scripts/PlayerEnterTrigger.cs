﻿/*
 * Jackson Laumann
 * Challenge
 * Increments score when hitting a "finish"
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            ScoreManager.score++;
            other.tag = "Untagged";
        }
    }
}
