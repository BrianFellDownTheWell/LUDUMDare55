using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTriggerHandler : MonoBehaviour
{
    public AudioClip testClip;
    public AudioSource testAudio;

    void Start()
    {
        testAudio = gameObject.GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player"))
        {
            testAudio.PlayOneShot(testClip, 1);
            //c.GetComponent<Collider2D>().enabled = false;
        }
    }
}
