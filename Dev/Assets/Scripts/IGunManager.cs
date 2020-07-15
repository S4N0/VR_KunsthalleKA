using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Prefabs.Interactions.Interactors;

public class IGunManager : MonoBehaviour
{
    public bool isGrabbed { get; private set; } = false;
    public GameObject bullet;
    public GameObject shooterPointer;

    OVRInput.Controller currentHand = OVRInput.Controller.None;
    //InteractorFacade currentHand = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Grabbed(InteractorFacade iFacade)
    {
        isGrabbed = true;

        if (currentHand != OVRInput.Controller.None)
        {
            Unregister(currentHand);
        }

        try
        {
            currentHand = iFacade.GrabAction.gameObject.GetComponent<OVRInputAxis1DAction>().controller;
            if (currentHand == OVRInput.Controller.LTouch)
            {
                InputManager.RegisterLeftTrigger(this.Shoot);
            }
            else
            {
                InputManager.RegisterRightTrigger(this.Shoot);
            }
        } catch (Exception e)
        {

        }
        

    }

    public void Ungrabbed(InteractorFacade iFacade)
    {
        isGrabbed = false;

        try
        {
            Unregister(iFacade.GrabAction.gameObject.GetComponent<OVRInputAxis1DAction>().controller);
        }
        catch (Exception e)
        {

        }

        currentHand = OVRInput.Controller.None;
    }

    public void Unregister(OVRInput.Controller controller)
    {
        if (controller == OVRInput.Controller.LTouch)
        {
            InputManager.UnregisterLeftTrigger(this.Shoot);
        }
        else
        {
            InputManager.UnregisterRightTrigger(this.Shoot);
        }
    }

    public void Shoot()
    {
        GameObject currentBullet = Instantiate(bullet, shooterPointer.transform.position, Quaternion.Euler(bullet.transform.rotation.eulerAngles + shooterPointer.transform.rotation.eulerAngles));
        currentBullet.GetComponent<Rigidbody>().AddForce(shooterPointer.transform.forward * 0.5f, ForceMode.Impulse);
    }
}
