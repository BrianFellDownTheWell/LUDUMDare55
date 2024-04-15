using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeowTrigger : MonoBehaviour
{
    private bool isTriggered;

    public AudioClip clip;
    public AudioSource source;

    public Meowy cat;
    // Start is called before the first frame update
    void Start()
    {
        isTriggered = false;
        source = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player") && !isTriggered && cat != null)
        {
            source.PlayOneShot(clip, 1);
            isTriggered = true;
            cat.appear();
        }
    }
}
