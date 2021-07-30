using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ThemeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Create a variable to store the current scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Get the index of the current scene
        int buildIndex = currentScene.buildIndex;

        // Check what scene it is
        switch (buildIndex)
        {
            case 0: // Begin menu
                Cursor.lockState = CursorLockMode.None;
                PlayerPrefs.SetFloat("bestTime", float.MaxValue);
                PlayerPrefs.SetFloat("bestDistance", 0);
                PlayerPrefs.SetInt("jumps", 0);
                PlayerPrefs.SetInt("deathsWin", 0);
                PlayerPrefs.SetInt("deaths", 0);
                FindObjectOfType<AudioManager>().Play("MainTheme");
                break;
            case 1: // Start menu
                Cursor.lockState = CursorLockMode.None;
                FindObjectOfType<AudioManager>().Play("MainTheme");
                break;
            case 2: // Gameplay
                PlayerPrefs.SetInt("jumps", 0);
                FindObjectOfType<AudioManager>().Play("MainTheme");
                break;
            case 3: // Results
                Cursor.lockState = CursorLockMode.None;
                break;
            default:
                return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
