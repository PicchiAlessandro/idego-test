using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ItemGrabberRHand : MonoBehaviour
{
    public Collider grabberCollider;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Grabbable" && Input.GetButtonDown("") && OVRInput.Axis1D.SecondaryIndexTrigger !=0)
        {
            Vector3 objPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            other.transform.position = objPos;
            other.transform.rotation = this.transform.rotation;
        }
    }
}
