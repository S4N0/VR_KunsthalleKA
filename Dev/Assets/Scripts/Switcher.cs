using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switcher : MonoBehaviour
{
    //public UnityEvent Switched;

    //public UnityAction ua;
    public UnityEvent[] actions;

    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Switch()
    {
        UnityEvent currentActions = actions[currentIndex];
        currentActions.Invoke();
        currentIndex++;
        currentIndex %= actions.Length;
    }
}
