using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrowth : MonoBehaviour
{

    public float growthRate = 0.1f;
    public float maxSize = 10.0f;
    private Vector3 initialScale;

    // Start is called before the first frame update
    void Start()
    {
        initialScale = transform.localScale;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < maxSize && transform.localScale.y < maxSize){
        float newScale = transform.localScale.x + growthRate * Time.deltaTime;
        transform.localScale = new Vector3(newScale, newScale, 1.0f);
        }
    }
}
