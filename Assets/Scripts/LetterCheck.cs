using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterCheck : MonoBehaviour
{
    public Material[] mats;
    public bool active;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EyeTracker")
        {
            gameObject.GetComponent<Renderer>().material = mats[1];
            active = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "EyeTracker")
        {
            gameObject.GetComponent<Renderer>().material = mats[0];
            active = false;
        }
    }
}
