using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn;
    public GameObject birdPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        Spawn();
    }

    public void Spawn()
    {
        GameObject clone = (GameObject)Instantiate(birdPrefab, spawn.transform.position, Quaternion.Euler(0f, 180f, 0f));
        Destroy(clone, 8.0f);
    }
}
