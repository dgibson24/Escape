using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerCapsule;

    [SerializeField]
    private GameObject StartClosed;

    [SerializeField]
    private GameObject StartOpen;

    void Update()
    {
        checkForPlayer();
    }

    public void checkForPlayer()
    {
        var doorPos = GameObject.Find("StartClosed").transform.position;
        var playerPos = GameObject.Find("PlayerCapsule").transform.position;

        double range = 2;

        if (Vector3.Distance(doorPos, playerPos) < range)
        {
            StartClosed.SetActive(false);
            StartOpen.SetActive(true);
        }
    }
}
