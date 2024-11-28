using System.Collections;
using UnityEngine;

public class InvisibleWallToggle : MonoBehaviour
{
    [Header("Wall Settings")]
    public GameObject[] invisibleWalls; // Array of wall colliders to toggle

    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        //Transform triggerPoint = gameObject.
        // Check if the interacting object is the player
        // Log the object that entered the trigger
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Destroying Walls");
            DeleteWalls();
        }
    }

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
