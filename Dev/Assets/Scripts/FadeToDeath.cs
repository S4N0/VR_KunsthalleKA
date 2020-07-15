using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class FadeToDeath : MonoBehaviour
{
    public float TimeToDeath;
    float alphaFactor = 0;

    // Start is called before the first frame update
    void Start()
    {
        float startalpha = this.gameObject.GetComponent<TextMeshPro>().color.a;

        alphaFactor = startalpha / TimeToDeath;

        Invoke("kill", TimeToDeath);
    }

    // Update is called once per frame
    void Update()
    {
        Color currentColor = this.gameObject.GetComponent<TextMeshPro>().color;
        currentColor = new Color(currentColor.a - (Time.deltaTime * alphaFactor), currentColor.r, currentColor.g, currentColor.b);

        this.gameObject.GetComponent<TextMeshPro>().color = currentColor;
    }

    void kill()
    {
        Destroy(this.gameObject);
    }
}
