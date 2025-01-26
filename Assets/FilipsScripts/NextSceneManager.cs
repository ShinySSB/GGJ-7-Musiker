using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class NextSceneManager : MonoBehaviour
{
    public GameObject LoadingScreen;
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

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            LoadingBar.value = progressValue;
            
            yield return null;
        }
    }
}
