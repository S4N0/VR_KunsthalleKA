using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public GameObject pointsDisplayPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collided(Collision collision)
    {
        if (collision.gameObject.layer != 16)
            return;

        ContactPoint cp = collision.GetContact(0);
        Destroy(collision.gameObject);

        float points = Vector3.Distance(cp.point, this.gameObject.transform.position);

        float maxPoints = 0.286f;
        float factor = (100.0f / maxPoints);

        int iPoints = Mathf.RoundToInt(Mathf.Abs((points * factor) - 100.0f));

        TextMeshPro pointsDisplay = Instantiate(pointsDisplayPrefab, cp.point, this.gameObject.transform.rotation).GetComponent<TextMeshPro>();
        pointsDisplay.text = "" + iPoints;

        //Debug.Log("Points: " + iPoints);
    }
}
