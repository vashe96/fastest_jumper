using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn;
    public GameObject birdPrefab;
    AudioSource audi;

    private void Awake()
    {
        audi = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("audio") == 0)
            audi.volume = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Spawn();
        audi.Play();
    }

    public void Spawn()
    {
        GameObject clone = (GameObject)Instantiate(birdPrefab, spawn.transform.position, Quaternion.Euler(0f, 180f, 0f));
        Destroy(clone, 12.0f);
    }
}
