using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public UnityEvent onPlayerDeath;
    public void PlayerDeath()
    {
        onPlayerDeath.Invoke();
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadSceneAsync(currentSceneName);
    }
}
