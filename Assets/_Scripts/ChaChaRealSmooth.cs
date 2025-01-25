using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class ChaChaRealSmooth : MonoBehaviour
{
    public float bounceSpeed = 8;
    public float bounceAmplitude = 0.05f;

    private float startHeight;
    private float timeOffset;

    
    void Start()
    {
        startHeight = transform.localPosition.x;
        timeOffset = Random.value * Mathf.PI * 2;
    }
    
    void Update()
    {
        float finalheight = startHeight + Mathf.Sin(Time.time * bounceSpeed + timeOffset) * bounceAmplitude;
        var position = transform.localPosition;
        position.x = finalheight;
        transform.localPosition = position;
    }
}

