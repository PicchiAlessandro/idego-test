using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ItemInteractorLHand : MonoBehaviour
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
            Vector3 objPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            other.transform.position = objPos;
            other.transform.rotation = this.transform.rotation;
        }
        else if (inHand != null)
        {
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
