using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed;
    private Vector2 velocity;
    private Rigidbody2D rb;

    public Sprite[] sprites;
    public SpriteRenderer sRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement
        if (Input.GetKey(KeyCode.W))
        {
            if (sprites[0] != null && sRenderer != null)
            {
                sRenderer.sprite = sprites[0];
            }
            velocity = new Vector2(0.0f, 1.0f) * Time.fixedDeltaTime * speed;
            rb.MovePosition(rb.position + velocity);
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (sprites[1] != null && sRenderer != null)
            {
                sRenderer.sprite = sprites[1];
            }
            velocity = new Vector2(0.0f, -1.0f) * Time.fixedDeltaTime * speed;
            rb.MovePosition(rb.position + velocity);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (sprites[2] != null && sRenderer != null)
            {
                sRenderer.sprite = sprites[2];
            }
            velocity = new Vector2(-1.0f, 0.0f) * Time.fixedDeltaTime * speed;
            rb.MovePosition(rb.position + velocity);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (sprites[3] != null && sRenderer != null)
            {
                sRenderer.sprite = sprites[3];
            }
            velocity = new Vector2(1.0f, 0.0f) * Time.fixedDeltaTime * speed;
            rb.MovePosition(rb.position + velocity);
        }
    }
}
