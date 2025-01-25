using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFix : MonoBehaviour
{
    public bool lockY;
    public bool lockX;
    public float yLockedValue;
    public float xLockedValue;

    private void LateUpdate()
    {
        var o = gameObject;
        var position = o.transform.position;

        if (lockY)
        {
            o.transform.position = new Vector3(position.x, yLockedValue, position.z);
        }
        else if (lockX)
        {
            o.transform.position = new Vector3(xLockedValue, position.y, position.z);
        }
    }

    public void SwapAxis()
    {
        lockY = !lockY;
        lockX = !lockX;

        if (lockX)
        {
            xLockedValue = gameObject.transform.position.x;
        }
        else if (lockY)
        {
            yLockedValue = gameObject.transform.position.y;
        }
    }

    public void UpdateAxisPosition(bool value)
    {
        //Do Something
    }
}
