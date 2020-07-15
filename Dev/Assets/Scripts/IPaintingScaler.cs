using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPaintingScaler : MonoBehaviour
{
    Transform iPaintingTransform;
    IPaintingManager painting;
    Vector3 startScale;
    // Start is called before the first frame update
    void Start()
    {
        iPaintingTransform = this.transform.GetChild(1);
        painting = iPaintingTransform.gameObject.GetComponent<IPaintingManager>();
        startScale = iPaintingTransform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scale(float scale)
    {
        if (!painting.IsSnapped())
            iPaintingTransform.localScale += new Vector3(scale, scale, scale);
    }

    public void ResetScale()
    {
        Debug.Log("Resetted");
        iPaintingTransform.localScale = startScale;
    }

}
