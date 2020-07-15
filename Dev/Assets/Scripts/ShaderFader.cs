using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderFader : MonoBehaviour
{
    float currentDelta = 0;
    float currentAlpha = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDelta != 0)
        {
            currentAlpha -= currentDelta * Time.deltaTime;
            currentAlpha = currentAlpha < 0 ? 0 : currentAlpha;

            Debug.Log(currentAlpha);

            Renderer[] allChildrenShaders = GetComponentsInChildren<Renderer>();

            foreach (Renderer child in allChildrenShaders)
            {
                //Color currentColor = child.material.color;
                child.material.color = new Color(255, 255, 255, currentAlpha);
                //child.material.color = new Color(currentColor.r, currentColor.g, currentColor.b, currentAlpha);
            }

            if (currentAlpha <= 0)
                currentDelta = 0;
        }
    }

    public void FadeRoomTransparent(float seconds)
    {
        currentDelta = 255.0f / (seconds);
        currentAlpha = 255;

        //Renderer[] allChildrenShaders = GetComponentsInChildren<Renderer>();
        //
        //foreach (Renderer child in allChildrenShaders)
        //{
        //    child.material. = false;
        //}
    }

    public void FadeRoomVisible(float seconds)
    {
        currentDelta = -255.0f / (seconds);
        currentAlpha = 0;
        FadeRoomNTP();
    }

    private void FadeRoomTP()
    {
        currentAlpha -= currentDelta;
        currentAlpha = currentAlpha < 0 ? 0 : currentAlpha;

        Renderer[] allChildrenShaders = GetComponentsInChildren<Renderer>();

        // Create a material with transparent diffuse shader
        Material transparentMaterial = new Material(Shader.Find("Transparent/Diffuse"));
        transparentMaterial.color = new Color(255, 255, 255, currentAlpha);

        foreach (Renderer child in allChildrenShaders)
        {
            //Color currentColor = child.material.color;
            child.material = transparentMaterial;
            //child.material.color = new Color(currentColor.r, currentColor.g, currentColor.b, currentAlpha);
        }

        if (currentAlpha > 0)
            Invoke("FadeRoomTP", 0.1f);
    }

    private void FadeRoomNTP()
    {
        currentAlpha -= currentDelta;
        currentAlpha = currentAlpha > 255 ? 255 : currentAlpha;

        Renderer[] allChildrenShaders = GetComponentsInChildren<Renderer>();

        // Create a material with transparent diffuse shader
        Material currentMaterial = new Material(Shader.Find("Standard"));
        currentMaterial.color = new Color(255, 255, 255, currentAlpha);

        foreach (Renderer child in allChildrenShaders)
        {
            child.material = currentMaterial;
        }

        if (currentAlpha > 0)
            Invoke("FadeRoomNTP", 0.1f);
    }
}
