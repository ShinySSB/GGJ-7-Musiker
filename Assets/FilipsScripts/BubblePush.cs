using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePush : MonoBehaviour
{
    [SerializeField] private float force, direction;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Hej");
            
            Vector2 movement = new Vector2(force * direction,0);

            movement *= Time.deltaTime;
        
            other.transform.Translate(movement);
        }
    }
}
