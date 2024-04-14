using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public AudioClip testClip;
    public AudioSource testAudio;

    private static int triggerCount = 0;
    private bool isTriggered;
    public Chest chest;

    void start()
    {
        isTriggered = false;
        testAudio = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player") && !isTriggered)
        {
            testAudio.PlayOneShot(testClip, 1);
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
