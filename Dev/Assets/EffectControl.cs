using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class EffectControl : MonoBehaviour
{
    public PostProcessVolume fx;

    ColorGrading colorGradingLayer = null;
    // Start is called before the first frame update
    void Start()
    {
        fx.profile.TryGetSettings(out colorGradingLayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor(Color c)
    {
        Color cColor = colorGradingLayer.colorFilter.value;
        colorGradingLayer.colorFilter.Interp(cColor, c, 2);
    }
}
