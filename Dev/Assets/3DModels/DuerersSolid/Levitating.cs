using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Levitating : MonoBehaviour
{
    public float sinOff = 0f;
    public float amplitude = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float floatingLevel = Mathf.Sin(Time.time + sinOff) * amplitude;
        gameObject.transform.Translate(0, 0, floatingLevel);

    }
}
