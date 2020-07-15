using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
{
    public float from = 0, to = 1;
    public float timeToGrow = 1.0f;

    public bool instantlyGrow = true;
    bool growing = false;
    float growFactor;
    // Start is called before the first frame update
    void Start()
    {
        if (instantlyGrow)
            growing = true;

        float growDistance = to - from;
        growFactor = growDistance / timeToGrow;
    }

    // Update is called once per frame
    void Update()
    {
        if (growing)
        {
            float currentScale = this.transform.localScale.x + (Time.deltaTime * growFactor);
            this.transform.localScale = new Vector3(currentScale, currentScale, currentScale);

            if ((currentScale > 0 && currentScale >= to))
                growing = false;
        }
    }

    public void StartGrowing()
    {
        growing = true;
    }
}
