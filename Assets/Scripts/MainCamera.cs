using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;
    public float smoothing = 2f;
    AudioSource audi;

    Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;
        audi = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("audio") == 0)
            audi.volume = 0;
    }

    void FixedUpdate()
    {
        Vector3 targetCameraPosition = target.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetCameraPosition, smoothing * Time.deltaTime);
    }
}
