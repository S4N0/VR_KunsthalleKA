using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBodyController : MonoBehaviour
{
    public GameObject HeadsetAlias;
    public GameObject PlayAreaAlias;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = HeadsetAlias.transform.position + new Vector3(0, -0.7f, -0.1f);
        this.transform.rotation = Quaternion.Euler(new Vector3(0, PlayAreaAlias.transform.rotation.y + HeadsetAlias.transform.localRotation.y, 0));
        //this.transform.rotation = PlayAreaAlias.transform.rotation;
    }
}
