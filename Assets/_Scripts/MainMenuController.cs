using System;
using System.Collections;
using System.Collections.Generic;
using SonityTemplate;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using Slider = UnityEngine.UI.Slider;


public class MainMenuController : MonoBehaviour
{



    public UnityEvent gameStart, levelSelect, settings, back;
    [Space(10)]
    public TMP_Text musicText, sfxText;
    public Slider musicSlider, SFXSlider;
    [Range(0f, 1f)]
    public float initSliderValue;
    [Space(10)]
    public UnityEvent buttonClick, buttonHover;
    private void Start()
    {
        musicSlider.value = initSliderValue;
        SFXSlider.value = initSliderValue;
        gameStart.Invoke();
    }

    public void LevelSelect()
    {
        Debug.Log("Play");
        levelSelect.Invoke();
        //SceneManager.LoadScene(1);
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

    public void musicSliderChange()
    {
        musicText.text = musicSlider.value.ToString("F2"); 
    }

    public void sfxSliderChange()
    {
        sfxText.text = SFXSlider.value.ToString("F2"); 
    }

    public void hoverSound()
    {
        Debug.Log("hoverSound");
        buttonHover.Invoke();
    }

    public void clickSound()
    {
        Debug.Log("clickSound");
        buttonClick.Invoke();
    }
}
