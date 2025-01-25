using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MusicTrigger : MonoBehaviour
{
    public UnityEvent _sceneStart;
    // Start is called before the first frame update
    void Start()
    {
        _sceneStart.Invoke();
    }
    
}
