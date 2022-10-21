/*
 * Jackson Laumann
 * Prototype 3
 * Continually spawns obstacles
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);

    private float startDelay = 2, repeatRate = 2;

    private PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.FindObjectOfType<PlayerController>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}
