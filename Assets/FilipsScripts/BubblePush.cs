using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePush : MonoBehaviour
{
    [SerializeField] private float force, direction;
    [SerializeField] private bool pushY;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hej");

            if (!pushY)
            {
                Vector3 movement = new Vector3(force * direction,0);
                movement *= Time.deltaTime;
                other.transform.Translate(movement);
            }
            else
            {
                Vector3 movement = new Vector3(0,force * direction);
                movement *= Time.deltaTime;
                other.transform.Translate(movement);
            }
        }
    }
}
