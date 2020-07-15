using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    X,
    Y,
    Z
}

public class ConstantMoving : MonoBehaviour
{
    public Direction movingDirection;
    public float speedPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentDistance = Time.deltaTime * speedPerSecond;
        switch (movingDirection)
        {
            case Direction.X:
                this.gameObject.transform.localPosition += new Vector3(currentDistance, 0, 0);
                break;
            case Direction.Y:
                this.gameObject.transform.localPosition += new Vector3(0, currentDistance, 0);
                break;
            case Direction.Z:
                this.gameObject.transform.localPosition += new Vector3(0, 0, currentDistance);
                break;
        }
    }
}
