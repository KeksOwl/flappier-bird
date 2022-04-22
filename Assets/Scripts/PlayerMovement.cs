using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody2D birdRigidBody;

    public float jumpVelocity = 3f;

    // Update is called once per frame
    void Update() {
        if (Time.timeScale != 0f && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))) {
            FindObjectOfType<AudioManager>().Play("wing");
            birdRigidBody.velocity = Vector2.up * jumpVelocity;
        }
    }
}
