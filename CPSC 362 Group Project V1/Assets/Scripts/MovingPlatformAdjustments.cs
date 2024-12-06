using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformAdjustments : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player lands on the platform
        if (collision.collider.CompareTag("Player"))
        {
            // Set the player as a child of the platform
            collision.collider.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the player leaves the platform
        if (collision.collider.CompareTag("Player"))
        {
            // Remove the player as a child of the platform
            collision.collider.transform.SetParent(null);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
