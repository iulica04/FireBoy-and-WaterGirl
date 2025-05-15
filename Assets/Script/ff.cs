using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ff : MonoBehaviour
{
    [SerializeField] Lever s;
    Vector3 newPosition;
    Vector3 oldPosition;

    void Start()
    {
        newPosition = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z); // 
        oldPosition = transform.position;

    }

    void Update()
    {
        if (s.MoveLift == true)
        {
            if (transform.position != newPosition)
                transform.position = Vector3.Lerp(transform.position, newPosition, 0.01f);
        }
        else
        {
            if (transform.position != oldPosition)
                transform.position = Vector3.Lerp(transform.position, oldPosition, 0.01f);
        }
    }
}
