/**
 * @file DeathScript.cs
 * @brief Handles the behavior when the player character dies in the game.
 *
 * This script is attached to an object that resets the player's position upon collision with obstacles tagged as 'Player'.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    /** @brief The initial starting point where the player respawns. */
    public GameObject startPoint;
    /** @brief The player game object. */
    public GameObject Player;

    private Rigidbody2D rb;

    /**
     * @brief Called before the first frame update.
     * 
     * Initializes the Rigidbody component of the player.
     */
    void Start()
    {
        rb = Player.GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component of the player
    }

    /**
     * @brief Handles collision with the player.
     * 
     * Resets the player's position and velocity to initial state when colliding with objects tagged as 'Player'.
     * @param other The collision data associated with this collision.
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Reset player position to the starting point
            Player.transform.position = startPoint.transform.position;
            // Reset player velocity to zero
            rb.velocity = Vector2.zero;
        }
    }
}
