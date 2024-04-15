using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public AudioClip shellClip;
    public AudioSource testAudio;

    public Sprite openSprite;
    public SpriteRenderer sRenderer;

    private static int triggerCount = 0;
    private static int targetCount = 4;
    private bool isTriggered;
    public Chest chest;

    public BobbingFood catfood;

    void start()
    {
        isTriggered = false;
        testAudio = gameObject.GetComponent<AudioSource>();
        sRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player") && !isTriggered)
        {
            testAudio.PlayOneShot(shellClip, 1);
            triggerCount++;
            isTriggered = true;
            Debug.Log(triggerCount);
            if (openSprite != null && sRenderer != null) {
                sRenderer.sprite = openSprite;
            }

            if(triggerCount >= targetCount)
            {
                catfood.startBob();
                chest.Open();
            }
        }
    }
}
