/**
 * @file Build.cs
 * @brief Provides build utilities within the Unity Editor.
 *
 * This script includes methods to perform tasks related to building and maintaining the project, such as linting.
 * It allows the addition of custom build steps that can be executed from the Unity Editor's menu.
 */

using UnityEditor;
using UnityEngine;

public class Build
{
    /**
     * @brief Adds a menu item to perform linting operations.
     * 
     * This static method adds a menu item "Build/Perform Linting" to the Unity Editor. When selected,
     * it executes linting tasks such as running Roslyn analyzers or other code quality checks.
     */
    [MenuItem("Build/Perform Linting")]
    public static void PerformLinting()
    {
        Debug.Log("Running Roslyn analyzers or other linting tasks...");
        // Add your linting code or analyzer code here
    }
}
