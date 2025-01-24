using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UIElements;


public class MainMenuController : MonoBehaviour
{
    public UnityEvent settings, back;

    public void Play()
    {
        Debug.Log("Play");
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        Debug.Log("settings");
        settings.Invoke();
    }

    public void Back()
    {
        Debug.Log("Back");
        back.Invoke();
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
