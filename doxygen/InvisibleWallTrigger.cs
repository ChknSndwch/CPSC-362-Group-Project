/**
 * @file InvisibleWallTrigger.cs
 * @brief Controls the behavior of invisible walls that the player can interact with.
 *
 * This script toggles the visibility and collision of walls when the player character interacts with them, 
 * typically used to manage dynamic obstacles in the game environment.
 */

using System.Collections;
using UnityEngine;

public class InvisibleWallToggle : MonoBehaviour
{
    /** @brief Array of wall GameObjects that can be toggled on and off. */
    [Header("Wall Settings")]
    public GameObject[] invisibleWalls; // Array of wall colliders to toggle

    /**
     * @brief Called when the game starts.
     * 
     * Method left intentionally empty.
     */
    private void Start()
    {

    }

    /**
     * @brief Handles the player entering the trigger zone.
     * 
     * Detects when the player enters the trigger and initiates the wall deletion process.
     * @param other Collider involved in the trigger event.
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the interacting object is the player and log the interaction
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Destroying Walls");
            DeleteWalls();
        }
    }

    /**
     * @brief Deletes all walls specified in the array.
     * 
     * Iterates through the array of GameObjects and destroys each one, effectively removing the wall from the game.
     */
    private void DeleteWalls()
    {
        foreach (GameObject wall in invisibleWalls)
        {
            if (wall != null)
            {
                Destroy(wall); // Permanently delete the wall GameObject
            }
        }
    }
}
