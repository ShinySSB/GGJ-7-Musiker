using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinishTrigger : MonoBehaviour
{
    public UnityEvent OnEnter;
    private void OnTriggerStay2D(Collider2D other)
    {
        OnEnter.Invoke();
    }
}
