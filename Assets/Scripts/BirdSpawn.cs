using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawn : MonoBehaviour
{
    public GameObject birdPrefab;
    public float respawnTime = 2.0f;
    public Vector3 spawnPosition;
    void Start()
    {
        spawnPosition = transform.position;
        GameObject clone = (GameObject)Instantiate(birdPrefab, spawnPosition, Quaternion.Euler(0f, 180f, 0f));
        Destroy(clone, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
