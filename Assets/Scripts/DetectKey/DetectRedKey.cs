using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRedKey : MonoBehaviour
{
    void Update()
    {
        checkForKey();
    }

    public void checkForKey()
    {
        var lockPosition = GameObject.Find("RedLock").transform.position;
        var keyPosition = GameObject.Find("RedKey").transform.position;

        var lockName = GameObject.Find("RedLock");

        double range = .5;

        if (Vector3.Distance(lockPosition, keyPosition) < range)
        {
            lockName.SetActive(false);
        }
    }
}
