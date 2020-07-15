using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputManager.RegisterOptionsButton(this.OptionsButtonPressed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OptionsButtonPressed()
    {
        this.gameObject.transform.GetChild(0).gameObject.SetActive(!this.gameObject.transform.GetChild(0).gameObject.activeInHierarchy);
    }
}
