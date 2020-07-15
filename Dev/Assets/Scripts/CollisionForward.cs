using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class CollisionEvent : UnityEvent<Collision>
{
}

public class CollisionForward : MonoBehaviour
{
    public CollisionEvent OnCollisionEnterEvent;
    public CollisionEvent OnCollisionStayEvent;
    public CollisionEvent OnCollisionExitEvent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        OnCollisionEnterEvent.Invoke(collision);
    }

    void OnCollisionStay(Collision collision)
    {
        OnCollisionStayEvent.Invoke(collision);
    }

    private void OnCollisionExit(Collision collision)
    {
        OnCollisionExitEvent.Invoke(collision);
    }
}
