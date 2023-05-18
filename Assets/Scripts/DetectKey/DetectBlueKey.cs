using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBlueKey : MonoBehaviour
{
    void Update()
    {
        checkForKey();
    }

    public void checkForKey()
    {
        var lockPosition = GameObject.Find("BlueLock").transform.position;
        var keyPosition = GameObject.Find("BlueKey").transform.position;

        var lockName = GameObject.Find("BlueLock");

        double range = .5;

        if (Vector3.Distance(lockPosition, keyPosition) < range)
        {
            lockName.SetActive(false);
        }
    }
}
