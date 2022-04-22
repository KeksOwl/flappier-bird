using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour {

    public GameObject objectToDestroy;
    public float destroyTimer = 5f; // in seconds

    // Update is called once per frame
    void FixedUpdate() {
        Destroy(objectToDestroy, destroyTimer);
    }
}
