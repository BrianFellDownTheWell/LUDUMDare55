using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    private static int triggerCount = 0;
    private bool isTriggered;
    public Chest chest;

    void start()
    {
        isTriggered = false;
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player") && !isTriggered)
        {
            triggerCount++;
            isTriggered = true;
            Debug.Log(triggerCount);
            if(triggerCount >= 4)
            {
                chest.Open();
            }
        }
    }
}
