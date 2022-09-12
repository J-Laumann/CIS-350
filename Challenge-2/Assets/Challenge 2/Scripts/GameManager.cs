/*
 * Jackson Laumann
 * Challenge 2
 * Manages health and score;
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gameOver;

    public static GameManager instance;

    public int health = 5, score = 0;

    public Text healthText, scoreText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
        scoreText.text = "Score: " + score;

        if(health <= 0)
        {
            Debug.Log("You Lose!");
            gameOver = true;
        }

        if(score >= 5)
        {
            Debug.Log("You Win!");
            gameOver = true;
        }

        if(Input.GetKeyDown(KeyCode.R) && gameOver)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
