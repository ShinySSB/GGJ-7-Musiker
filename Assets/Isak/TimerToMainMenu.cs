using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerToMainMenu : MonoBehaviour
{
    [Range(1, 30)]
    public float timer;

    public UnityEvent timerDone;
    void Start()
    {
        StartCoroutine(TimerToMain());
    }

    IEnumerator TimerToMain()
    {
        yield return new WaitForSecondsRealtime(timer);
        timerDone.Invoke();
    }
}
