using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_For_Swtich_X : MonoBehaviour
{
    Vector3 newposition;
    Vector3 oldPosition;
    public bool moveLift = false;
    public float length = 4f;
    public float speed = 0.01f;

    void Start()
    {
        newposition = new Vector3(transform.position.x + length, transform.position.y, transform.position.z); // Mutare pe X
        oldPosition = transform.position;
        moveLift = false;
    }

    void Update()
    {
        if (moveLift)
        {
            if (transform.position != newposition)
                transform.position = Vector3.Lerp(transform.position, newposition, speed);
        }
        else
        {
            if (transform.position != oldPosition)
                transform.position = Vector3.Lerp(transform.position, oldPosition, speed);
        }
    }
}
