using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_For_Swtich_Y : MonoBehaviour
{

    Vector3 newposition;
    Vector3 oldPosition;
    public bool moveLift = false;
    public float length = 4f;
    void Start()
    {
        newposition = new Vector3(transform.position.x, transform.position.y + length, transform.position.z);
        oldPosition = transform.position;
        moveLift = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveLift == true)
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
