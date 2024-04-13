using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed;
    private Vector2 velocity;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement
        if (Input.GetKey(KeyCode.W))
        {
            velocity = new Vector2(0.0f, 1.0f) * Time.fixedDeltaTime * speed;
            rb.MovePosition(rb.position + velocity);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity = new Vector2(0.0f, -1.0f) * Time.fixedDeltaTime * speed;
            rb.MovePosition(rb.position + velocity);
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity = new Vector2(-1.0f, 0.0f) * Time.fixedDeltaTime * speed;
            rb.MovePosition(rb.position + velocity);
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity = new Vector2(1.0f, 0.0f) * Time.fixedDeltaTime * speed;
            rb.MovePosition(rb.position + velocity);
        }
    }
}
