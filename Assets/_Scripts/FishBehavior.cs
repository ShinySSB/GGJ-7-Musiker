using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehavior : MonoBehaviour
{
    public Transform a;
    public Transform b;

    public float speed;
    private Transform current;
    private Transform target;
    private float t;
    
    // Start is called before the first frame update
    void Start()
    {
        target = b;
        transform.position = a.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        t += Time.deltaTime * speed;

        float smoothT = 0.5f * (1 - Mathf.Cos(Mathf.PI * t));

        transform.position = Vector3.Lerp(a.position, b.position, smoothT);

        if (t >= 1f)
        {
            (a, b) = (b, a);
            t = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerDamage>().PlayerDeath();
        }
    }
}
