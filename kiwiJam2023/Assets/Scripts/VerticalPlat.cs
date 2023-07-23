using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalPlat : MonoBehaviour
{

    public float moveSpeed = 5f;     
    public float moveDistance = 5f;  

    private Vector3 initialPosition; 
    private bool movingup = true;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        Vector3 targetPosition;
        if (movingup)
            targetPosition = initialPosition + Vector3.up * moveDistance;
        else
            targetPosition = initialPosition - Vector3.up * moveDistance;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);


        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            movingup = !movingup;
        }
    }
}
