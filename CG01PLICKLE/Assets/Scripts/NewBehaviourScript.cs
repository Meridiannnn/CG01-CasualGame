using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // add a public variable force allowing us to have a variable force
    public float force = 10;

    // FixedUpdate is used to update for physics
    void FixedUpdate()
    {
        // use rigidbodies and get the rigidbody component to add a force
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 0, force));
    }
}