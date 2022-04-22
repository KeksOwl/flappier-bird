using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMovement : MonoBehaviour {
    // Reference to the Rigidbody component
    public Rigidbody2D pipesRigidBody;

    // Update is called once per frame
    void FixedUpdate() {
        pipesRigidBody.velocity = new Vector2(-2f, 0);
    }
}
