/**
 * @file EnemyAIPatrolling.cs
 * @brief Manages patrol movements of an enemy character between defined waypoints.
 *
 * This script enables an enemy game object to move along a series of waypoints, 
 * creating a patrolling effect. The enemy automatically reverses direction when reaching the end of its path.
 */

using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
// Automatically adds BoxCollider2D component when adding script
[RequireComponent(typeof(BoxCollider2D))]

public class NewBehaviourScript : MonoBehaviour
{
    /** @brief A list of transforms that represent waypoints for patrolling. */
    public List<Transform> points;
    /** @brief Index of the next waypoint in the list. */
    public int nextID = 0;
    /** @brief Value that determines the direction of movement through the waypoints. */
    int idChangeValue = 1;
    /** @brief Movement speed of the enemy. */
    public float speed = 2;

    /**
     * @brief Initializes the component.
     * 
     * Resets and initializes waypoints and other necessary properties when the script is reset in the editor.
     */
    private void Reset()
    {
        Init();
    }

    /**
     * @brief Initializes waypoints and configures the root and waypoint structure.
     * 
     * Configures the BoxCollider to be a trigger and sets up a simple path between two points for demonstration purposes.
     */
    void Init()
    {
        // Ensure the collider is set as a trigger
        GetComponent<BoxCollider2D>().isTrigger = true;

        // Create root object to organize waypoints
        GameObject root = new GameObject(name + "_Root");
        root.transform.position = transform.position;
        transform.SetParent(transform);
        GameObject waypoints = new GameObject("Waypoints");
        waypoints.transform.SetParent(root.transform);
        waypoints.transform.position = root.transform.position;

        // Create initial waypoints
        GameObject p1 = new GameObject("Point1");
        p1.transform.SetParent(waypoints.transform);
        p1.transform.position = root.transform.position;
        GameObject p2 = new GameObject("Point2");
        p2.transform.SetParent(waypoints.transform);
        p2.transform.position = root.transform.position;

        points = new List<Transform>();
        points.Add(p1.transform);
        points.Add(p2.transform);
    }

    /**
     * @brief Called once per frame to move the enemy towards the next waypoint.
     */
    private void Update()
    {
        moveNextPoint();
    }

    /**
     * @brief Moves the enemy towards the next waypoint and changes direction at endpoints.
     * 
     * Moves the enemy object towards the next waypoint and handles the logic for changing direction
     * when reaching the beginning or end of the waypoint list.
     */
    void moveNextPoint()
    {
        Transform goalPoint = points[nextID];
        // Adjust the enemy's facing direction based on the movement direction
        if (goalPoint.transform.position.x > transform.position.x)
            transform.localScale = new Vector3(-1, 1, 1);
        else
            transform.localScale = new Vector3(1, 1, 1);

        // Move towards the next waypoint
        transform.position = Vector2.MoveTowards(transform.position, goalPoint.position, speed * Time.deltaTime);
        // Change direction at the waypoints
        if (Vector2.Distance(transform.position, goalPoint.position) < 1f)
        {
            if (nextID == points.Count - 1)
                idChangeValue = -1;
            else if (nextID == 0)
                idChangeValue = 1;

            nextID += idChangeValue;
        }
    }
}
