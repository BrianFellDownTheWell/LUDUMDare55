using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource backgroundPlayer;
    public AudioClip newClip;

    void Start()
    {
        backgroundPlayer = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player") && !backgroundPlayer.loop)
        {
            backgroundPlayer.loop = true;
            backgroundPlayer.Play();
        }
    }
}
