using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meowy : MonoBehaviour
{
    public Sprite meowSprite;
    public SpriteRenderer sRenderer;
    public Chest chest;

    public AudioClip winClip;
    public AudioSource testAudio;
    public string winScene;
    // Start is called before the first frame update
    void Start()
    {
        testAudio = gameObject.GetComponent<AudioSource>();
    }
    public void appear()
    {
        if (meowSprite != null && sRenderer != null)
        {
            sRenderer.sprite = meowSprite;
        }
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        Debug.Log(chest.isWin());
        if (c.CompareTag("Player") && chest.isWin())
        {
            testAudio.PlayOneShot(winClip, 1);
            Debug.Log("You win (for real)!");
            SceneManager.LoadScene(winScene);
        }
    }
}
