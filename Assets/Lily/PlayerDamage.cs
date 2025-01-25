using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public UnityEvent onPlayerDeath;
    public float waitTime;
    private Vector3 defaultrespawnPos;
    void Start()
    {
        defaultrespawnPos = gameObject.transform.position;
    }
    
    public void PlayerDeath()
    {
        onPlayerDeath.Invoke();
    }

    public void RespawnPlayer()
    {
        Vector3 respawnPos;
        try
        {
            respawnPos = GetComponent<CheckpointTracker>().GetCheckpoint();
        }
        catch (NullReferenceException)
        {
            respawnPos = defaultrespawnPos;
        }
        
        gameObject.transform.position = respawnPos;
    }
}
