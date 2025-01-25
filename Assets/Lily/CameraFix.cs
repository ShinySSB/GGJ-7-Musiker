using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFix : MonoBehaviour
{
    public float yLockedValue;

    private void LateUpdate()
    {
        var o = gameObject;
        var position = o.transform.position;
        o.transform.position = new Vector3(position.x, yLockedValue, position.z);
    }
}
