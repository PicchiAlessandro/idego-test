using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public float targetFps = 72.0f;

    void Start()
    {
        OVRPlugin.systemDisplayFrequency = targetFps;
    }


    void Update()
    {
        
    }
}
