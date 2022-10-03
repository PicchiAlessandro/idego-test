using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public bool lookPlayer;
    public GameObject target;

    void Start()
    {
        if (lookPlayer)
            target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        gameObject.transform.LookAt(target.transform);
    }
}
