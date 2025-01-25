using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTracker : MonoBehaviour
{
    public Checkpoint activeCheckpoint;

    public void UpdateCheckpoint(Checkpoint checkpoint)
    {
        activeCheckpoint = checkpoint;
    }

    public Vector3 GetCheckpoint()
    {
        return activeCheckpoint.transform.position;
    }
}
