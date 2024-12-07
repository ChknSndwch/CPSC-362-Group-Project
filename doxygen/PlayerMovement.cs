/**
 * @file PlayerMovement.cs
 * @brief Manages the movement and jumping behavior of the player character.
 *
 * This script provides horizontal movement and jumping functionalities to the player's character.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /** @brief Movement speed of the player. */
    public float speed;
    private Rigidbody2D rb;
    private float Move;

    /** @brief Jump force of the player. */
    public float jump;
    /** @brief Indicates if the player is currently jumping. */
    public bool isJumping;
    /** @brief Counts how many times the player has jumped. */
    public int time;

    /**
     * @brief Called before the first frame update.
     * 
     * Initializes the Rigidbody2D component for movement handling.
     */
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /**
     * @brief Called once per frame, handles player inputs and movement physics.
     */
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && (isJumping == false || time <= 2))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("jump");
            time++;
        }
    }

    /**
     * @brief Handles collisions with the ground to manage jumping state.
     * 
     * Resets jump flags upon collision with the ground.
     * @param other The collision data associated with ground collision.
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            time = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            time++;
        }
    }
}
