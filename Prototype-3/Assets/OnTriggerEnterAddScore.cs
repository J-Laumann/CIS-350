/*
 * Jackson Laumann
 * Prototype 3
 * Increases score with trigger
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterAddScore : MonoBehaviour
{
    private UIManager uIManager;
    private bool triggered = false;

    private void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
