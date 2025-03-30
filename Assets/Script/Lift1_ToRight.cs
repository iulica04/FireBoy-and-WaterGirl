using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift1_ToRight : MonoBehaviour
{
    Vector3 newposition;
    Vector3 oldPosition;
    public bool moveLift = false;
    public float length = 2.0f;

    void Start()
    {
        newposition = new Vector3(transform.position.x + length, transform.position.y, transform.position.z); // Mutare în dreapta
        oldPosition = transform.position;
        moveLift = false;
    }

    void Update()
    {
        if (moveLift)
        {
            if (transform.position != newposition)
                transform.position = Vector3.Lerp(transform.position, newposition, 0.01f);
        }
        else
        {
            if (transform.position != oldPosition)
                transform.position = Vector3.Lerp(transform.position, oldPosition, 0.01f);
        }
    }
}
