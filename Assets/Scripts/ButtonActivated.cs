using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivated : MonoBehaviour
{
    public Material[] mats;
    public bool riattivabile;
    public bool stato;

    public void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Interactor")
        {
            if (!stato)
            {
                Debug.Log("BOTTONE ATTIVATO!!!");
                stato = true;
                gameObject.GetComponent<Renderer>().material = mats[1];
            }
            else if (riattivabile && stato)
            {
                Debug.Log("BOTTONE DISATTIVATO!!!");
                stato = false;
                gameObject.GetComponent<Renderer>().material = mats[0];
            }
        }
    }
}
