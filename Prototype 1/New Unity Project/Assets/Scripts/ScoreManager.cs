/*
 * Jackson Laumann
 * Prototype 1
 * Controls the score and win/lose condition
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textbox;

    private void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // If game isnt over, add score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        if(score >= 3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win!\nPress R to try again!";
            }
            else
            {
                textbox.text = "You Lose!\nPress R to try again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
