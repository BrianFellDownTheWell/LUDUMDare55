using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Collision with player
        if (collision.gameObject.CompareTag("Player"))
        {
            //Rigidbody2D playerRB = collision.gameObject.GetComponent<RigidBody2D>();
            //if(playerRB != null) {
                // Upon collision, set player's 
                

            //} 
        }
    }
}
