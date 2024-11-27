using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyAIMovement : MonoBehaviour
{
    public float bounceForce = 100f; // Set the bounce force to control height

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Apply an upward force when the object hits the ground
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x, bounceForce);
    }
}
