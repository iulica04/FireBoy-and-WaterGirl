using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift_For_Lever_Y : MonoBehaviour
{
    [SerializeField] private Lever s; 
    private Vector3 newPosition;
    private Vector3 oldPosition;
    public float length = 3.5f;
    public float speed = 0.01f;

    void Start()
    {
        oldPosition = transform.position;
        newPosition = new Vector3(transform.position.x, transform.position.y + length, transform.position.z); // Mișcare pe Y
    }

    void Update()
    {
        if (s != null && s.MoveLift) 
        {
            if (transform.position.y != newPosition.y)
                transform.position = Vector3.Lerp(transform.position, newPosition, speed);
        }
        else
        {
            if (transform.position.y != oldPosition.y)
                transform.position = Vector3.Lerp(transform.position, oldPosition, speed);
        }
    }
}
