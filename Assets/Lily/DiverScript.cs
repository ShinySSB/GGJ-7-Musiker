using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiverScript : MonoBehaviour
{
    public Transform pointToStick;

    private void FixedUpdate()
    {
        gameObject.transform.position = pointToStick.TransformPoint(pointToStick.localPosition);
    }
}
