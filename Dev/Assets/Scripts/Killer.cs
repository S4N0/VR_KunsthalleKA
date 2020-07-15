using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Killer : MonoBehaviour
{
    public float TimeToDeathInSeconds = 0;

    void Start()
    {
        Invoke("KillTimerElapsed", TimeToDeathInSeconds);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void KillTimerElapsed()
    {
        Destroy(this.gameObject);
    }
}
