/**
 * @file CameraMovement.cs
 * @brief Controls the game camera to follow a designated target in the game world.
 *
 * This script is responsible for updating the camera's position each frame to center on a specified target,
 * providing a smooth following camera effect in gameplay.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    /** @brief The target GameObject that the camera should follow. */
    public GameObject target;

    /**
     * @brief Called before the first frame update.
     * 
     * Method left intentionally empty.
     */
    void Start()
    {
    }

    /**
     * @brief Called once per frame to update the camera's position.
     * 
     * Ensures the camera's position matches the target's position with a fixed offset in the z-axis to maintain perspective.
     */
    void Update()
    {
        // Update the camera's position to follow the target, maintaining a fixed distance on the z-axis.
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
    }
}
