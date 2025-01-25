using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsFlipscripts : MonoBehaviour
{
    [SerializeField] private SpriteRenderer legs;
    
    private void FixedUpdate()
    { 
        float inputX = Input.GetAxis("Horizontal");
        
        DoFlip(inputX);
    }

    private void DoFlip(float x)
    {
        if (Math.Abs(x - 1) < double.Epsilon)
            legs.flipX = false;
        else if (Math.Abs(x - (-1)) < double.Epsilon)
            legs.flipX = true;
    }
}
