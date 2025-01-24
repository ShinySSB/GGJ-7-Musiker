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
    private float sinTime;
    
    // Start is called before the first frame update
    void Start()
    {
        current = a;
        target = b;
        transform.position = current.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != target.position)
        {
            print("I am not yet at target");
            sinTime += Time.deltaTime * speed;
            sinTime = Mathf.Clamp(sinTime, 0, Mathf.PI);
            float t = Evaluate(sinTime);
            transform.position = Vector2.Lerp(current.position, transform.position, t);
        }
        
        Swap();
    }

    public float Evaluate(float x)
    {
        return 0.5f * Mathf.Sin(x - Mathf.PI / 2f) + 0.5f;
    }

    public void Swap()
    {
        if (Vector3.Distance(transform.position, target.position) > 0.05)
        {
            return;
        }
        print("I am swapping");
        (current, target) = (target, current);
        sinTime = 0;
    }
}
