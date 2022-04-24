using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public void OnButton()
    {
        Debug.Log("Clear Button was pressed");
    }

    public void OnStartButton()
    {
        SceneManager.LoadScene(1); // number of the scene in build settings/ Unity

        // Debug.Log("Start Button was pressed");
    }

    public void OnQuitButton()
    {
        Application.Quit();

        // Debug.Log("Quit Button was pressed");
    }
}
