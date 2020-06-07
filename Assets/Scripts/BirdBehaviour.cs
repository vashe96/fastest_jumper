using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdBehaviour : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        float speed = Random.Range(15f, 20f);
        float targetRandom = Random.Range(0f, 2f);
        transform.position = Vector3.MoveTowards(transform.position, targetRandom * (new Vector3(11, 6, -30)), speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Death death = new Death();
        death.DoDeath();
    }
}
