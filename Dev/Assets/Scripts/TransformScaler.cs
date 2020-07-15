using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scale(float scale)
    {
        this.gameObject.transform.localScale += new Vector3(scale, scale, scale);
    }

    public void ResetScale()
    {
        this.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }

    public static void ResetScale(GameObject go)
    {
        go.transform.localScale = new Vector3(1, 1, 1);
    }
}
