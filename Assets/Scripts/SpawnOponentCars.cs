using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOponentCars : MonoBehaviour
{
    public GameObject[] spawnPrefabs;   // prefabs to spawn randomly
    public float spawnInterval = 3.0f;  // interval of times in seconds between spawns
    public float spawnDelay = 1.0f;     // initial delay before the first spawn

    private float spawnTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = spawnInterval - spawnDelay;
    }

    // If the time has elapsed, reset the timer and spawn a car
    void Update()
    {
        spawnTimer += Time.deltaTime; 
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0.0f;

            if (spawnPrefabs.Length > 0)
            {
                // pick a random number to spawn one of the car
                int i = Random.Range(0, spawnPrefabs.Length);
                Instantiate(spawnPrefabs[i], transform.position, transform.rotation);
            }
        }
    }
}
