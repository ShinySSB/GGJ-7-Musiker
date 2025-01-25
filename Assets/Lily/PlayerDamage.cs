using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public UnityEvent onPlayerDeath;
    public float waitTime;
    public void PlayerDeath()
    {
        onPlayerDeath.Invoke();
        StartCoroutine(RespawnPlayer());
    }

    public IEnumerator RespawnPlayer()
    {
        yield return new WaitForSeconds(waitTime);
        Vector3 respawnPos = GetComponent<CheckpointTracker>().GetCheckpoint();
        /*if (respawnPos. == null)
        {
            
        }*/

        gameObject.transform.position = respawnPos;
    }
}
