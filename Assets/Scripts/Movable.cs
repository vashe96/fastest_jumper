using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    Vector3 firstTarget, secondTarget, startPosition;
    float speed;
    private void Start()
    {
        startPosition = transform.position;
        firstTarget = startPosition + new Vector3(Random.Range(-5f, 5f), Random.Range(-2f, 2f), 0);
        secondTarget = startPosition + new Vector3(Random.Range(-5f, 5f), Random.Range(-2f, 2f), 0);
        speed = 1f;
    }
    
    void Update()
    {
        transform.position = Vector3.Lerp(firstTarget, secondTarget, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}