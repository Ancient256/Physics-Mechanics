using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDeletion : MonoBehaviour
{
    // Specify the layer that triggers deletion
    public string ballLayer = "Ball";

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the specified layer
        if (collision.gameObject.layer == LayerMask.NameToLayer(ballLayer))
        {
            // Delete the current object
            Destroy(gameObject);
        }
    }
}
