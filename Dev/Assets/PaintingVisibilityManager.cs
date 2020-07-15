using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingVisibilityManager : MonoBehaviour
{
    public static PaintingVisibilityManager currentPaintingVisibilityManager;

    public GameObject[] paintings;

    // Start is called before the first frame update
    void Start()
    {
        currentPaintingVisibilityManager = this;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactivateAll()
    {
        foreach (GameObject p in paintings)
        {
            p.SetActive(false);
        }
    }

    public void ActivateAll()
    {
        foreach (GameObject p in paintings)
        {
            p.SetActive(true);
        }
    }
}
