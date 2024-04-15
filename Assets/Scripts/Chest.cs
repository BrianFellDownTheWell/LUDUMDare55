using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public AudioClip chestClip;
    public AudioClip winClip;
    public AudioSource testAudio;

    public Sprite openSprite;
    public SpriteRenderer sRenderer;
    private bool isOpen;
    private bool win;

    void start()
    {
        testAudio = gameObject.GetComponent<AudioSource>();
        sRenderer = GetComponent<SpriteRenderer>();
        isOpen = false;
        win = false;
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player") && isOpen)
        {
            Debug.Log("You win!");
            testAudio.PlayOneShot(winClip, 1);
            win = true;
            Debug.Log(isWin());
        }
    }

    public void Open()
    {
        testAudio.PlayOneShot(chestClip, 1);
        Debug.Log("Opened chest");
        isOpen = true;
        if (openSprite != null && sRenderer != null)
        {
            sRenderer.sprite = openSprite;
        }
    }

    public bool isWin()
    {
        return win;
        //return true;
    }
}
