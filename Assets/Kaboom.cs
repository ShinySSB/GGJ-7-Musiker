using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Kaboom : MonoBehaviour
{
    public GameObject[] bombsToDestroy;
    public float waitForAnimationTime;

    public void detonation()
    {
        foreach (var bomb in bombsToDestroy)
        {
            bomb.GetComponent<Animator>().Play("Explosion");
        }
        StartCoroutine(WaitForAnimation());
    }

    private IEnumerator WaitForAnimation()
    {
        yield return new WaitForSeconds(waitForAnimationTime);
        foreach (var bomb in bombsToDestroy)
        {
            bomb.SetActive(false);
        }
        gameObject.SetActive(false);
    }
}

