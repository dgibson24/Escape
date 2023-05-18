using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActivateDoorToggle : MonoBehaviour
{
    [SerializeField]
    private GameObject doorLock;

    [SerializeField]
    private GameObject wallClosed;

    [SerializeField]
    private GameObject wallOpen;

    void Update()
    {
        checkForUnlock();
    }

    private void checkForUnlock()
    {
        if(!doorLock.activeInHierarchy)
        {
            wallClosed.SetActive(false);
            wallOpen.SetActive(true);
        }
    }
}
