using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobbingFood : MonoBehaviour
{
    public float bobHeight = 0.5f;
    public float bobSpeed = 1.0f;
    private Vector2 startPos;
    // Start is called before the first frame update

    public Sprite bobSprite;
    public SpriteRenderer sRenderer;

    void Start()
    {
        startPos = transform.position;
    }

    public void startBob()
    {
        if (bobSprite != null && sRenderer != null)
        {
            sRenderer.sprite = bobSprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.Sin(Time.time * bobSpeed) * bobHeight;
        transform.position = startPos + new Vector2(0, offset);
    }
}
