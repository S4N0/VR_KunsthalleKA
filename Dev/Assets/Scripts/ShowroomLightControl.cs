using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ShowroomLightControl : MonoBehaviour
{
    Light[] spots;
    public float fadingSpeed = 0.01f;

    bool fading = false;
    Color fadeColor;
    float currentFadeTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        spots = new Light[this.transform.childCount];

        for (int i = 0; i < spots.Length; i++)
        {
            try
            {
                spots[i] = this.transform.GetChild(i).GetComponent<Light>();
            } catch (Exception e)
            {
    
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (fading)
        {
            if (currentFadeTime > 1)
            {
                currentFadeTime = 1;
                fading = false;
            }
            Color cColor = Color.Lerp(spots[0].color, fadeColor, currentFadeTime);

            currentFadeTime += fadingSpeed;

            SetColor(cColor);
        }
    }

    public void SetColor(Color c)
    {
        for (int i = 0; i < spots.Length; i++)
        {
            spots[i].color = c;
        }
    }

    public void Fade(Color c, float fadingSpeed = 0.01f)
    {
        this.fadingSpeed = fadingSpeed;
        fadeColor = c;
        fading = true;
        currentFadeTime = 0;
    }
}
