using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectStartKey : MonoBehaviour
{
    void Update()
    {
        checkForKey();
    }

    public void checkForKey()
    {
        var lockPosition = GameObject.Find("StartLock").transform.position;
        var keyPosition = GameObject.Find("StartKey").transform.position;

        var lockName = GameObject.Find("StartLock");

        double range = .5;

        if (Vector3.Distance(lockPosition, keyPosition) < range)
        {
            lockName.SetActive(false);
        }
    }
}
