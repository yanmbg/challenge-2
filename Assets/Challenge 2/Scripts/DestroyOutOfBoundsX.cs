using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOnContact : MonoBehaviour
{
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object we collided with has the tag "Dog"
        if (collision.gameObject.CompareTag("Dog"))
        {
            // Destroy the ball (this game object) on contact with the dog
            Destroy(gameObject);
        }
    }
}
