using UnityEditor;
using UnityEngine;

public class Build
{
    // Static method that will be called from Unity batch mode
    [MenuItem("Build/Perform Linting")]
    public static void PerformLinting()
    {
        Debug.Log("Running Roslyn analyzers or other linting tasks...");
        // Add your linting code or analyzer code here
    }
}