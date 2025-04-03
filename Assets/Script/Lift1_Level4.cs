using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift1_Level4 : MonoBehaviour
{

    Vector3 newposition;
    Vector3 oldPosition;
    public bool moveLift = false;
    // Start is called before the first frame update
    void Start()
    {
        newposition = new Vector3(transform.position.x, transform.position.y + 4f, transform.position.z);
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
