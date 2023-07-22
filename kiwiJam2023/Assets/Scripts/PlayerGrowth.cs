using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrowth : MonoBehaviour
{
    public float growthRate = 0.1f;
    public float maxSize = 10.0f; 
    private Vector3 initialScale;
    public float growthInterval = 1.0f;
    private float newScale;
    private float timePassed;
    
    // Start is called before the first frame update
    public void reset()
    {
        initialScale = transform.localScale;
        newScale = initialScale.z;
        timePassed = 0f;
        //StartCoroutine(GrowOverTime());
    }

    void Update(){
        timePassed += Time.deltaTime;
        if(timePassed>growthInterval && newScale < maxSize){
            timePassed = 0;
            newScale = newScale + growthRate;
            transform.localScale = new Vector3(newScale, newScale, 1.0f);
        }
    }
}
