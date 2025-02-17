using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoadingSceneManager : MonoBehaviour
{
    public GameObject LoadingScreen, MainScreen;
    public Slider LoadingBar;
    public TMP_Text LoadingText;

    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(LoadSceneIE(sceneIndex));
        LoadingText.text = "Loading Scene " + sceneIndex;
    }

    IEnumerator LoadSceneIE(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        LoadingScreen.SetActive(true);
        MainScreen.SetActive(false);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            LoadingBar.value = progressValue;
            
            yield return null;
        }
    }
}
