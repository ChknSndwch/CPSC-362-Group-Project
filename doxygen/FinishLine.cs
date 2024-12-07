/**
 * @file FinishLine.cs
 * @brief Manages level completion and transitions in the game.
 *
 * This script triggers a level transition when the player character reaches the finish line of the current level.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    /** @brief The name of the next level to load upon completion of the current level. */
    public string nextLevelName;

    /**
     * @brief Called when the game starts.
     * 
     * Method left intentionally empty.
     */
    private void Start() { }

    /**
     * @brief Handles collisions with the finish line.
     * 
     * Detects when the player collides with the finish line and triggers a level change.
     * @param other The collision data associated with this collision.
     */
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Triggered Finishline"); // Log the event for debugging purposes
            SceneManager.LoadScene(nextLevelName); // Load the next level
        }
    }
}
