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
    
    public float movementSpeed;
    private Vector2 speed = new Vector2(0, 0);

    [SerializeField] private float maxGravity, minGravity, timeToGrow, timeToShrink;
    private float gravity;

    private void Awake()
    {
        TryGetComponent(out Rigidbody2D);
        speed.x = movementSpeed;
        //speed.y = movementSpeed;
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") == 0 || Input.GetAxis("Vertical") == 0)
        {
            return;
        }
        else
        {
            DoSidewaysMovement();
            DoInflate();
        }
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
    
    
}
