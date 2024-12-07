/**
 * @file TempPlayerMovement.cs
 * @brief Controls basic movement mechanics for a player character in a temporary setup.
 *
 * This script is designed to manage simple 2D movement and jumping for a player character using Unity's physics system.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPlayerMovement : MonoBehaviour
{
    /** @brief Movement speed of the player along the horizontal axis. */
    [SerializeField] private float speed;
    /** @brief Rigidbody component for handling physics-based movement. */
    private Rigidbody2D body;

    /**
     * @brief Called before the first frame update to initialize components.
     * 
     * Retrieves and stores the Rigidbody2D component from the game object to which this script is attached.
     */
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    /**
     * @brief Called once per frame to update the player's movement.
     * 
     * Handles the horizontal movement based on player input and allows jumping when the space key is pressed.
     */
    void Update()
    {
        // Updates the player's horizontal velocity based on input
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        // Allows the player to jump by setting the vertical velocity when the space bar is pressed
        if (Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x, speed);
        }
    }
}
