using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor.TerrainTools;

public class PointKeeper : MonoBehaviour
{
    public static PointKeeper instance;
    public Text totalPoints;
    private int points = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("Saved Pointkeeper");
            UpdatePointsDisplay();
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Destroyed Pointkeeper");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // Initialize score at the start
        Debug.Log("Starting Pointkeeper");
        UpdatePointsDisplay();

    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //MUST MATCH NAME OF NEW TEXT
        Debug.Log("Trying to find new text");
        GameObject newTextObject = GameObject.Find("PointText"); 
        if (newTextObject != null)
        {
            totalPoints = newTextObject.GetComponent<Text>();
            UpdatePointsDisplay();
        }
    }

    // Add points to the score
    public void AddPoints(int newpoints)
    {
        points += newpoints;
        Debug.Log("Score added: " + points + " | Total Score: " + points);
        UpdatePointsDisplay();
    }

    private void UpdatePointsDisplay()
    {
        totalPoints.text = "Points: " + points;
        Debug.Log("You should have a Total Score: " + points);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
