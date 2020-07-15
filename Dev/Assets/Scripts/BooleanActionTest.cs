using Malimbe.MemberChangeMethod;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Action;
using Zinnia.Pointer;
using Zinnia.Data.Attribute;

public class BooleanActionTest : MonoBehaviour
{
    public BooleanAction ActivationAction;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [CalledAfterChangeOf(nameof(ActivationAction))]
    protected virtual void OnAfterActivationActionChange()
    {
        Debug.LogWarning("Pressed!");
    }
}
