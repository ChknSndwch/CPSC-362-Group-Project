/**
 * @file PauseMenu.cs
 * @brief Manages the pause menu interactions in the game.
 *
 * This script controls the display of the pause menu and the game's paused state.
 * It also provides methods to resume or quit the game.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    /** @brief The pause menu GameObject. */
    public GameObject pauseMenu;

    /**
     * @brief Called before the first frame update.
     * 
     * Initializes the cursor visibility state.
     */
    void Start()
    {
        // Initially hides the cursor when the game starts
        Cursor.visible = false;
    }

    /**
     * @brief Called once per frame, checks for pause menu toggle.
     * 
     * Monitors the 'Escape' key to toggle the pause menu visibility and game state.
     */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauseMenu.activeSelf)
            {
                // Pauses the game and shows the pause menu
                Time.timeScale = 0f;
                pauseMenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                // Resumes the game and hides the pause menu
                Time.timeScale = 1f;
                pauseMenu.SetActive(false);
                Cursor.visible = false;
            }
        }
    }

    /**
     * @brief Quits the game application.
     * 
     * Can be called from a UI button to quit the game.
     */
    public void quit()
    {
        Application.Quit();
    }

    /**
     * @brief Resumes the game from pause.
     * 
     * Disables the pause menu and sets game time scale back to normal.
     */
    public void resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        Cursor.visible = false;
    }
}
