using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed;
    private Vector2 velocity;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(rb.position + new Vector2(0.0f, 1.0f) * Time.fixedDeltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(rb.position + new Vector2(0.0f, -1.0f) * Time.fixedDeltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(rb.position + new Vector2(-1.0f, 0.0f) * Time.fixedDeltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(rb.position + new Vector2(1.0f, 0.0f) * Time.fixedDeltaTime * speed);
        }
    }
}
