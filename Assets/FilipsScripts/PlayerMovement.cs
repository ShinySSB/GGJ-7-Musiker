using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

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

    private void Awake()
    {
        TryGetComponent(out Rigidbody2D);
        speed.x = movementSpeed;
    }

    void FixedUpdate()
    {
        DoSidewaysMovement();
        DoInflate();
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
            DoSizeChange(inputY);
        }
        else if (inputY == -1 && Rigidbody2D.gravityScale <= maxGravity)
        {
            //Go down
            Rigidbody2D.gravityScale += (Time.deltaTime * timeToShrink);
        }
    }

    private void DoSizeChange(float input)
    {
        Vector3 vMax = new Vector3(Time.deltaTime * maxSize, Time.deltaTime * maxSize,0);
        Vector3 vMin = new Vector3(Time.deltaTime * minSize, Time.deltaTime * minSize,0);
        if (input == 1)
        {
            gameObject.transform.localScale += vMax;
        }
        else if (input == -1)
        {
            gameObject.transform.localScale -= vMin;
        }
    }
}
