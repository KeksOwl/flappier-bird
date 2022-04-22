using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject objectToSpawn;

    public bool isTimer;
    public float timeToSpawn;
    private float currentTimeToSpawn;

    public float bottomRange = 0.6f;
    public float topRange = 2.4f;

    void Start() {
        currentTimeToSpawn = timeToSpawn;
    }

    void FixedUpdate() {
        if (isTimer) {
            UpdateTimer();
        }
    }

    void UpdateTimer() {
        if (currentTimeToSpawn > 0) {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }

    void SpawnObject() {
        Instantiate(objectToSpawn, new Vector2(transform.position.x, transform.position.y + Random.Range(bottomRange, topRange)), transform.rotation);
    }
}
