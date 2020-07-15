using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Action;

public class OVRInputTouchAction : BooleanAction
{
    public OVRInput.Controller controller;
    public OVRInput.Touch touch;

    void Update() {
        Receive(OVRInput.Get(touch, controller));
    }
}
