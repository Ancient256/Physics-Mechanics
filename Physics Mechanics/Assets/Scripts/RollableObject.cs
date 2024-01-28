using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollableObject : MonoBehaviour
{
    public float rollForce = 5.0f;
    private bool isRolling = false;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("RollableObject script requires a Rigidbody component.");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!isRolling && collision.relativeVelocity.magnitude > 2.0f)
        {
            StartRolling(collision.contacts[0].normal);
        }
    }

    void StartRolling(Vector3 direction)
    {
        isRolling = true;

        // Apply force to start rolling in the given direction
        rb.AddForce(direction * rollForce, ForceMode.Impulse);

        // Enable rotation to simulate rolling
        rb.freezeRotation = false;
    }
}
