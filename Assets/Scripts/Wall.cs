using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    private Rigidbody2D playerRB;
    private void OnCollisionEnter(Collision collision)
    {
        // Collision with player
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision");
            playerRB = collision.gameObject.GetComponent<Rigidbody2D>();
            if(playerRB != null) {
                // Upon collision, set player's velocity to 0 
                playerRB.velocity = Vector2.zero;
            } 
        }
    }
}
