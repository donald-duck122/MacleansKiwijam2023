using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveSpeed = 5f;     
    public float moveDistance = 5f;  

    private Vector3 initialPosition; 
    private bool movingRight = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        Vector3 targetPosition;
        if (movingRight)
            targetPosition = initialPosition + Vector3.right * moveDistance;
        else
            targetPosition = initialPosition - Vector3.right * moveDistance;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);


        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            movingRight = !movingRight;
        }
    }
}
