using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGreenKey : MonoBehaviour
{
    void Update()
    {
        checkForKey();
    }

    public void checkForKey()
    {
        var lockPosition = GameObject.Find("GreenLock").transform.position;
        var keyPosition = GameObject.Find("GreenKey").transform.position;

        var lockName = GameObject.Find("GreenLock");

        double range = .5;

        if (Vector3.Distance(lockPosition, keyPosition) < range)
        {
            lockName.SetActive(false);
        }
    }
}
