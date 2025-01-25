using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bomb : MonoBehaviour
{
    public UnityEvent onTriggered;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            onTriggered.Invoke();
            other.GetComponent<PlayerDamage>().PlayerDeath();
        }
    }
}
