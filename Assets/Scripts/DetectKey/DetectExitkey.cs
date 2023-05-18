using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectExitkey : MonoBehaviour
{
    void Update()
    {
        checkForKey();
    }

    public void checkForKey()
    {
        var lockPosition = GameObject.Find("ExitLock").transform.position;
        var keyPosition = GameObject.Find("ExitKey").transform.position;

        var lockName = GameObject.Find("ExitLock");

        double range = .5;

        if (Vector3.Distance(lockPosition, keyPosition) < range)
        {
            lockName.SetActive(false);
        }
    }
}
