using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenFinalScore : MonoBehaviour
{
    public Text totalPoints;
    // Start is called before the first frame update
    void Start()
    {
        UpdatePointsDisplay();

    }

    private void UpdatePointsDisplay()
    {
        totalPoints.text = "Final Score: " + PointKeeper.instance.GetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
