using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterActivation : MonoBehaviour
{
    public GameObject[] triggers;
    public bool t1, t2;
    public GameObject targetDoor;
    public Transform pointA, pointB;
    public float timer, maxTime;
    public float doorspeed;

    void Start()
    {
        timer = maxTime;
        doorspeed = (pointB.position.y - pointA.position.y) / maxTime;
    }

    void Update()
    {
        t1 = triggers[0].GetComponent<LetterCheck>().active;
        t2 = triggers[1].GetComponent<LetterCheck>().active;
        if (t1 && t2)
        {

            targetDoor.transform.position = new Vector3(targetDoor.transform.position.x, targetDoor.transform.position.y + (doorspeed * Time.deltaTime), targetDoor.transform.position.z);
            if (targetDoor.transform.position.y >= pointB.position.y)
            {
                targetDoor.SetActive(false);
            }
        }
        else if (pointA.position.y < targetDoor.transform.position.y)
        {
            targetDoor.transform.position = new Vector3(targetDoor.transform.position.x, targetDoor.transform.position.y - (doorspeed * Time.deltaTime), targetDoor.transform.position.z);
        }
    }
}
