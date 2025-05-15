using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_For_Lever_X : MonoBehaviour
{
    [SerializeField] private Lever s; 
    private Vector3 newPosition;
    private Vector3 oldPosition;
    public float length = 3.5f;
    public float speed = 0.01f;

    void Start()
    {
        oldPosition = transform.position;
        newPosition = new Vector3(transform.position.x + length, transform.position.y, transform.position.z); // Mișcare pe X
    }

    void Update()
    {
        if (s != null && s.MoveLift) 
        {
            if (transform.position.x != newPosition.x)
                transform.position = Vector3.Lerp(transform.position, newPosition, speed);
        }
        else
        {
            if (transform.position.x != oldPosition.x)
                transform.position = Vector3.Lerp(transform.position, oldPosition, speed);
        }
    }
}