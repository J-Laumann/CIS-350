/*
 * Jackson Laumann
 * Prototype 2
 * destroys food or animals if out of bounds, and decreases health if animal past bottom
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < bottomBound)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();

            Destroy(gameObject);
        }
    }
}
