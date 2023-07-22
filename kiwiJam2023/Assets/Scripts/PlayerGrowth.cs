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
    

    // Start is called before the first frame update
    void Start()
    {
        
        initialScale = transform.localScale;
        newScale = transform.localScale.z;

        StartCoroutine(GrowOverTime());

        
    }

    private IEnumerator GrowOverTime()
    {
        while (newScale < maxSize && newScale < maxSize)
        {
            yield return new WaitForSeconds(growthInterval);
        
            newScale = newScale + growthRate;
            transform.localScale = new Vector3(newScale, newScale, 1.0f);

        }
    }
}
