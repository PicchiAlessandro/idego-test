using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attivabile : MonoBehaviour
{
    public bool attivato = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (attivato)
            this.gameObject.SetActive(false);
    }
}
