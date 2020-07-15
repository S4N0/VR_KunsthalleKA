using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagingUtilities : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Snapped(GameObject go)
    {
        Debug.Log("Try Snapped");
        try
        {
            go.GetComponent<IPaintingManager>().Snapped();
        }
        catch (Exception e)
        {

        }
    }

    public void Unsnapped(GameObject go)
    {
        Debug.Log("Try Unsnapped");
        try
        {
            go.GetComponent<IPaintingManager>().Unsnapped();
        }
        catch (Exception e)
        {

        }
    }
}
