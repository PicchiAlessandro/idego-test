using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ItemInteractorRHand : MonoBehaviour
{
    public Collider grabberCollider;
    public GameObject inHand;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Grabbable" && OVRInput.Get(OVRInput.Button.SecondaryHandTrigger) && OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            inHand = other.gameObject;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.transform.SetParent(this.transform);
        }
        else if (inHand != null)
        {
            other.gameObject.transform.SetParent(null);
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;          
            var velocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch);
            inHand.GetComponent<Rigidbody>().velocity = velocity;
            inHand = null;
        }
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TASTO TOCCATO!!!!");
        if (other.gameObject.tag == "Button")
        {
            other.GetComponent<ButtonActivated>().Activation();
        }
    }
    */
}
