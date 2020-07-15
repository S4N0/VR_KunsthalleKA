using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPrinter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void printFloat(float f)
    {
        Debug.LogWarning("Warning: " + f);
        Debug.Log("Log: " + f);
    }
}
