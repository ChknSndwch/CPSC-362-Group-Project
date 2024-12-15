using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public int coinValue = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    { 
    }

    private void OnTriggerEnter2D(Collider2D coinCollision)
    {
        if (coinCollision.CompareTag("Player"))
        {
            // Disable the collider to prevent further trigger events
            GetComponent<Collider2D>().enabled = false;

            // Add points to the score
            PointKeeper.instance.AddPoints(coinValue);

            // Play the coin sound using the SoundManager
            SoundManager.instance.PlayCoinSound();

            // Destroy the coin
            Destroy(gameObject);
        }
    }


    //if (coinCollision.CompareTag("Player"))
    //{
    //    PointKeeper.instance.AddPoints(coinValue);
    //    Destroy(gameObject);
    //}
}
