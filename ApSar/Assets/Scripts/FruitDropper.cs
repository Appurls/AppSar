using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDropper : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    public float spawnRate = 1f;
    public float spawnRadius = 5f;

    

    public Boolean spawn_fruits = true;

    void Start()
    {
        InvokeRepeating("SpawnFruit", 0f, spawnRate);
    }

    void SpawnFruit()
    {
        // Randomly select a fruit prefab
        GameObject selectedFruit = fruitPrefabs[UnityEngine.Random.Range(0, fruitPrefabs.Length)];

        // Generate a random spawn position within the spawnRadius
        Vector3 spawnPosition = transform.position + new Vector3(UnityEngine.Random.Range(-spawnRadius, spawnRadius), 0f, 0f);

        // Instantiate the selected fruit at the spawn position
        if(spawn_fruits){
        Instantiate(selectedFruit, spawnPosition, Quaternion.identity);
        }
    }
}

