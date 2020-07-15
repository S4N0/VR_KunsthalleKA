using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimationScript : MonoBehaviour
{
    Animator cAnimator;
    // Start is called before the first frame update
    void Start()
    {
        cAnimator = this.gameObject.GetComponent<Animator>();
        playAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cAnimator.Play("Armature|ArmatureAction");
        }
    }

    private void playAnimation()
    {
        Debug.Log("play Animation");
        //cAnimator.Play("Armature|ArmatureAction");
        //Invoke("playAnimation", 10);
    }
}
