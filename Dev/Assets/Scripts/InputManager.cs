using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Zinnia.Action;

public class InputManager : MonoBehaviour
{
    static UnityEvent LeftIndexTrigger = new UnityEvent();
    static UnityEvent RightIndexTrigger = new UnityEvent();
    static UnityEvent OptionsButtonPressed = new UnityEvent();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region LeftIndexTrigger
    public void LeftIndexTriggered(bool triggered)
    {
        if (triggered)
            LeftIndexTrigger.Invoke();
    }

    public static void RegisterLeftTrigger(UnityAction action)
    {
        LeftIndexTrigger.AddListener(action);
    }

    public static void UnregisterLeftTrigger(UnityAction action)
    {
        LeftIndexTrigger.RemoveListener(action);
    }
    #endregion

    #region RightIndexTrigger
    public void RightIndexTriggered(bool triggered)
    {
        if (triggered)
            RightIndexTrigger.Invoke();
    }

    public static void RegisterRightTrigger(UnityAction action)
    {
        RightIndexTrigger.AddListener(action);
    }

    public static void UnregisterRightTrigger(UnityAction action)
    {
        RightIndexTrigger.RemoveListener(action);
    }
    #endregion

    #region OptionsButton

    public void OptionsButtonValueChanged(bool triggered)
    {
        if (triggered)
            OptionsButtonPressed.Invoke();
    }

    public static void RegisterOptionsButton(UnityAction action)
    {
        OptionsButtonPressed.AddListener(action);
    }

    public static void UnregisterOptionsButton(UnityAction action)
    {
        OptionsButtonPressed.RemoveListener(action);
    }

    #endregion
}
