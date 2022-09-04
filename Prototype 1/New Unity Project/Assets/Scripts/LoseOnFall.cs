/*
 * Jackson Laumann
 * Prototype 1
 * Makes the player lose when falling off
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
