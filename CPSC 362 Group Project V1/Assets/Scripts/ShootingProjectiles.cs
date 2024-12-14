using UnityEngine;

public class ShootingProjectiles : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public Transform player;
    public float projectileSpeed = 10f;
    public float fireInterval = 2f;

    private float fireTimer;

    void Update()
    {
        fireTimer += Time.deltaTime;

        if (fireTimer >= fireInterval)
        {
            FireProjectile();
            fireTimer = 0f;
        }
    }

    void FireProjectile()
    {
        if (player == null) return; // Ensure the player reference is assigned

        // Calculate direction to the player
        Vector2 direction = (player.position - firePoint.position).normalized;

        // Instantiate the projectile
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);

        // Set the projectile's velocity
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = direction * projectileSpeed;
        }

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        projectile.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
