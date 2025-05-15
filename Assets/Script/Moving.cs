using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private float moveDistance = 2f; // Distance to move left and right
    [SerializeField] private float moveSpeed = 2f; // Speed of movement

    private Vector3 leftPosition;
    private Vector3 rightPosition;
    private bool movingRight = true;

    void Start()
    {
        leftPosition = new Vector3(transform.position.x - moveDistance, transform.position.y, transform.position.z);
        rightPosition = new Vector3(transform.position.x + moveDistance, transform.position.y, transform.position.z);
    }

    void Update()
    {
        if (movingRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, rightPosition, moveSpeed * Time.deltaTime);
            if (transform.position == rightPosition)
                movingRight = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, leftPosition, moveSpeed * Time.deltaTime);
            if (transform.position == leftPosition)
                movingRight = true;
        }
    }
}
