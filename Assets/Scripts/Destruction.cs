using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    private ParticleSystem particle;
    public GameObject platform;
    public MeshRenderer cube;

    AudioSource audioSource;
    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            StartCoroutine(Break());
        }           
    }

    private IEnumerator Break()
    {
        particle.Play();
        audioSource.Play();
        cube.enabled = false;

        yield return new WaitForSeconds(particle.main.startLifetime.constantMax);
        Destroy(platform);
    }
}
