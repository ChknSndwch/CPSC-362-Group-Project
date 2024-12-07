/**
 * @file BouncyAIMovement.cs
 * @brief Controls the bouncing movement of an AI character.
 *
 * This script is attached to an AI character object and manages its bouncing motion by applying an upward force each time it collides with the ground or other designated surfaces.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyAIMovement : MonoBehaviour
{
    /** @brief The force applied upward when colliding with the ground. */
    public float bounceForce = 100f; // Set the bounce force to control height

    /**
     * @brief Handles collision events for the AI character.
     * 
     * Applies an upward force to the AI's Rigidbody2D component when it collides with another object, simulating a bounce.
     * @param collision Information about the collision, including the colliding object.
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Access the Rigidbody2D component of the AI character
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        // Apply an upward force by setting the vertical component of the velocity
        rb.velocity = new Vector2(rb.velocity.x, bounceForce);
    }
}
