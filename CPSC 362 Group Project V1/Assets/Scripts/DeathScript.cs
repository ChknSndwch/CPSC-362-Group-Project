using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = Player.GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component of the player
    }

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