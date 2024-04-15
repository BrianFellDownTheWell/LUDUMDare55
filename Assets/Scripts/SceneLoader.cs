using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //public string scene;
    public Transform teleportDestination;

    //public AudioSource backgroundPlayer;
    //public AudioClip newClip;

    void Start()
    {
        //backgroundPlayer = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Player"))
        {
            //SceneManager.LoadScene(scene, LoadSceneMode.Additive);
            c.transform.position = teleportDestination.position;
            //backgroundPlayer.loop = false;
            //if (backgroundPlayer.isPlaying)
            //{
            //    backgroundPlayer.Stop();
            //}
            //Debug.Log(backgroundPlayer.isPlaying);
            //backgroundPlayer.clip = newClip;
            //backgroundPlayer.loop = true;
            //backgroundPlayer.Play();
        }
    }
}
