/**
 * @file Coin.cs
 * @brief Manages coin interactions in the game.
 *
 * This script is attached to coin objects that players can collect for points. It handles the detection of player
 * collisions and awards points accordingly.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    /** @brief The value of the coin in terms of game points. */
    public int coinValue = 10;

    /**
     * @brief Called before the first frame update.
     * 
     * Method left intentionally empty.
     */
    void Start()
    {
    }

    /**
     * @brief Called once per frame.
     * 
     * Method left intentionally empty.
     */
    void Update()
    {
    }

    /**
     * @brief Detects collision with the player and awards points.
     * 
     * When the player collides with a coin, this function disables the coin's collider, awards points, and destroys the coin object.
     * @param coinCollision The collider involved in this trigger event.
     */
    private void OnTriggerEnter2D(Collider2D coinCollision)
    {
        if (coinCollision.CompareTag("Player"))
        {
            // Disable the collider to prevent further trigger events
            GetComponent<Collider2D>().enabled = false;

            // Add points to the score
            PointKeeper.instance.AddPoints(coinValue);

            // Destroy the coin to simulate collection
            Destroy(gameObject);
        }
    }
}
