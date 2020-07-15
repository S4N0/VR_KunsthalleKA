using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
    public float xAmplitude = 1f;
    public float yAmplitude = 0.4f;
    public float scalefactor = 1f;
    public float startOffset = 0;


    float xOld;
    float yOld;
    float zOld;

    // Start is called before the first frame update
    void Start()
    {
        xAmplitude *= scalefactor;
        yAmplitude *= scalefactor;

        xOld = gameObject.transform.position.x;
        yOld = gameObject.transform.position.y;
        zOld = gameObject.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        
        float xMotion = Mathf.Sin(Time.time+startOffset)*xAmplitude;
        float yMotion = Mathf.Cos(Time.time+startOffset)*yAmplitude;
        gameObject.transform.position = new Vector3(xOld, yOld + yMotion, zOld - xMotion);
    }
}
