using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionPlayer : MonoBehaviour
{
    public GameObject resetPoint;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object colliding has the tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reset the player's position to the reset point
            collision.gameObject.transform.position = resetPoint.transform.position;
        }
    }
}
