using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPurpleKey : MonoBehaviour
{
    void Update()
    {
        checkForKey();
    }

    public void checkForKey()
    {
        var lockPosition = GameObject.Find("PurpleLock").transform.position;
        var keyPosition = GameObject.Find("PurpleKey").transform.position;

        var lockName = GameObject.Find("PurpleLock");

        double range = .5;

        if (Vector3.Distance(lockPosition, keyPosition) < range)
        {
            lockName.SetActive(false);
        }
    }
}
