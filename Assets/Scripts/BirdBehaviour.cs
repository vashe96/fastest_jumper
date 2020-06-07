using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdBehaviour : MonoBehaviour
{
    public GameObject canvas;

    void Update()
    {
        float speed = Random.Range(15f, 20f);
        float targetRandom = Random.Range(0f, 2f);

        Vector3 targetDelta = new Vector3(0, 0, -60);
        transform.position = Vector3.MoveTowards(transform.position, targetDelta, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
    }
}
