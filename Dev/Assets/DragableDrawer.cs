using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragableDrawer : MonoBehaviour
{
    bool grabbed = false;

    public enum Direction
    {
        X,
        Y,
        Z
    }

    public Direction moveableDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (grabbed)
        {

        }
    }
}
