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

    [SerializeField] private float maxGravity, minGravity, timeToInflate;
    private float gravity;
    [SerializeField] private float logBase;

    private void Awake()
    {
        TryGetComponent(out Rigidbody2D);
        speed.x = movementSpeed;
        speed.y = movementSpeed;
    }

    void Update()
    {
        /*if (Input.GetAxis("Horizontal") == 0 || Input.GetAxis("Vertical") == 0)
        {
            return;
        }
        else
        {
            DoSidewaysMovement();
            DoInflate();
        }
        */
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
            Rigidbody2D.gravityScale -= (Time.deltaTime * timeToInflate);
        }
        else if (inputY == -1 && Rigidbody2D.gravityScale <= maxGravity)
        {
            //Go down
            /*gravity -= Mathf.Log((Time.deltaTime * timeToInflate), logBase).ConvertTo<float>();
            Debug.Log(gravity);
            float var = Mathf.Clamp(gravity, minGravity, maxGravity);
            Rigidbody2D.gravityScale = var;*/
            Rigidbody2D.gravityScale += (Time.deltaTime * timeToInflate);
        }
    }
}
