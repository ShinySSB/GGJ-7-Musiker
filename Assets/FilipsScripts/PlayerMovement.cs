using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    
    [Header("Character Controlls")]
    
    public float movementSpeed;
    private Vector2 speed = new Vector2(0, 0);
    
    [SerializeField] private float maxGravity, minGravity, timeToGrow, timeToShrink;
    private float gravity;
    
    [Space (15)]
    [Header("Max and min y value")]
    [SerializeField] private float maxSize;

    [SerializeField] private float minSize;
    
    public float changeDuration = 5f;
    private Vector3 targetScale;
    private Vector3 startScale;
    private float t = 0;

    private void Awake()
    {
        //For movement
        TryGetComponent(out Rigidbody2D);
        speed.x = movementSpeed;
        //For size change
        startScale = transform.localScale;
        targetScale = Vector3.one * maxSize;
        t = 0;
    }

    void FixedUpdate()
    {
        DoSidewaysMovement();
        DoInflate();
        DoSizeChange();
    }

    private void DoSidewaysMovement()
    {
        float inputX = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(speed.x * inputX,0);

        movement *= Time.deltaTime;
        
        transform.Translate(movement);
    }
    private void DoInflate()
    {
        float inputY = Input.GetAxis("Vertical");

        if (inputY == 1 && Rigidbody2D.gravityScale >= minGravity)
        {
            //Go up
            Rigidbody2D.gravityScale -= (Time.deltaTime * timeToGrow);
        }
        else if (inputY == -1 && Rigidbody2D.gravityScale <= maxGravity)
        {
            //Go down
            Rigidbody2D.gravityScale += (Time.deltaTime * timeToShrink);
        }
    }

    private void DoSizeChange()
    {
        float inputY = Input.GetAxis("Vertical");

        if (inputY == 1)
        {
            t += Time.deltaTime/ changeDuration;
            t = Mathf.Clamp(t, minSize, maxSize - 1);
            Debug.Log(t);
            Vector3 newScale = Vector3.Lerp(startScale, targetScale, t);
            transform.localScale = newScale;
        }
        else if (inputY == -1)
        {
            t -= Time.deltaTime * 10 / changeDuration;
            t = Mathf.Clamp(t, minSize, maxSize - 1);
            Debug.Log(t);
            Vector3 newScale = Vector3.Lerp(startScale, targetScale, t);
            transform.localScale = newScale;
        }
    }

    public void DoReset()
    {
        transform.localScale = startScale;
        Rigidbody2D.gravityScale = maxGravity;
        t = minSize;
    }
}
