using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.InteractableSnapZone;

public class IPaintingManager : MonoBehaviour
{
    [SerializeField]
    string SceneName = "";

    [SerializeField]
    SnapZoneFacade startSnapZone;

    bool isSnapped = true;
    bool isGrabbed = false;

    Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        startScale = this.transform.localScale;
        startSnapZone.Snap(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsSnapped()
    {
        return isSnapped;
    }

    public void Snapped()
    {
        Debug.Log("Snapped");
        isSnapped = true;
    }

    public void Unsnapped()
    {
        Debug.Log("Unsnapped");
        isSnapped = false;
    }

    public bool IsGrabbed()
    {
        return isGrabbed;
    }

    public void Grabbed()
    {
        isGrabbed = true;
    }

    public void Ungrabbed()
    {
        isGrabbed = false;
    }

    public void Scale(float scale)
    {
        if (!isSnapped)
            this.transform.localScale += new Vector3(scale, scale, scale);
    }

    public void ResetScale()
    {
        this.transform.localScale = startScale;
    }

    public void PlayEffect()
    {

    }

    public string GetSceneName()
    {
        return SceneName;
    }
}
