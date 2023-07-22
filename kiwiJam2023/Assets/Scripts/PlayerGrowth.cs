using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrowth : MonoBehaviour
{

    public float growthRate = 0.1f;
    public float maxSize = 10.0f;
    private Vector3 initialScale;
    public float growthInterval = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
        initialScale = transform.localScale;
        StartCoroutine(GrowOverTime());

        
    }

    private IEnumerator GrowOverTime()
    {
        while (transform.localScale.x < maxSize && transform.localScale.y < maxSize)
        {
            yield return new WaitForSeconds(growthInterval);
        
            float newScale = transform.localScale.y + growthRate;
            transform.localScale = new Vector3(newScale, newScale, 1.0f);

        }
    }
}
