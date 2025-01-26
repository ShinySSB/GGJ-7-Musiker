using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombSwitch : MonoBehaviour
{
    public GameObject bombToDestroy;
    public UnityEvent onDetonate;
    public float waitForAnimationTime;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        onDetonate.Invoke();
        bombToDestroy.GetComponent<Animator>().Play("Explosion");
        StartCoroutine(WaitForAnimation());

    }

    private IEnumerator WaitForAnimation()
    {
        yield return new WaitForSeconds(waitForAnimationTime);
        bombToDestroy.SetActive(false);
        gameObject.SetActive(false);
    }
}
