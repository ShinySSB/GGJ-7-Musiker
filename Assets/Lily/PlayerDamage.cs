using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public UnityEvent onPlayerDeath;
    public IEnumerator PlayerDeath()
    {
        onPlayerDeath.Invoke();
        Vector3 respawnPos = GetComponent<CheckpointTracker>().GetCheckpoint();
        gameObject.transform.position = respawnPos;
        yield return null;
    }
}
