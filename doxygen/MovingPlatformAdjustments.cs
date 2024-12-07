/**
 * @file MovingPlatformAdjustments.cs
 * @brief Manages interactions between the player and moving platforms in the game.
 *
 * This script is used to attach the player to a moving platform when they land on it,
 * and detach them when they leave it, ensuring the player moves with the platform.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformAdjustments : MonoBehaviour
{
    /**
     * @brief Handles the player landing on the platform.
     * 
     * When the player collides with the platform, this function sets the player as a child of the platform.
     * This makes the player move together with the platform.
     * @param collision Information about the collision, including the object involved.
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player lands on the platform
        if (collision.collider.CompareTag("Player"))
        {
            // Set the player as a child of the platform to move together
            collision.collider.transform.SetParent(transform);
        }
    }

    /**
     * @brief Handles the player leaving the platform.
     * 
     * When the player leaves the platform, this function removes the player from being a child of the platform.
     * This stops the player from moving with the platform.
     * @param collision Information about the collision, indicating the player leaving the platform.
     */
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the player leaves the platform
        if (collision.collider.CompareTag("Player"))
        {
            // Remove the player as a child of the platform
            collision.collider.transform.SetParent(null);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Method left intentionally empty
    }

    // Update is called once per frame
    void Update()
    {
        // Method left intentionally empty
    }
}
