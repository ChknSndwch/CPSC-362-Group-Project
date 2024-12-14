using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public string nextLevelName;
    private void Start(){}

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Triggered Finishline"); // Add this line for debugging
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
