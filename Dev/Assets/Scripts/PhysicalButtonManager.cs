using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Zinnia.Data.Type;

public class PhysicalButtonManager : MonoBehaviour
{
    public FloatRange pressRange { get; set; } = new FloatRange(0.8f, 1f);
    public UnityEvent onPressed;

    bool alreadyPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void positionChanged(float normalizedPosition)
    {
        if (alreadyPressed)
        {
            if (normalizedPosition == 0)
                alreadyPressed = false;
        } else
        {
            if (pressRange.Contains(normalizedPosition))
            {
                alreadyPressed = true;

                if (onPressed != null)
                {
                    Debug.Log("Button Pressed");
                    onPressed.Invoke();
                }
            }
        }
        

    }
}
