using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class NumpadLogic : MonoBehaviour
{
    public string winCode = "1234";
    protected string currentCode = "0000";
    public UnityEvent onWin;
    public TMPro.TextMeshProUGUI display;


    void Awake() {
        if (display)
            display.text = currentCode;
    }

    public void ButtonPressed(int val) {
        currentCode = currentCode.Substring(1) + val.ToString();
        if (display != null)
            display.text = currentCode;

        if (currentCode.Equals(winCode)) {
            if (onWin != null) {
                onWin.Invoke();
            }
        }
    }
}
