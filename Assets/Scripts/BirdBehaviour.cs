using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdBehaviour : MonoBehaviour
{
    GameObject deathCanvas;
    Vector3 destination;
    private void Start()
    {        
        deathCanvas = GameObject.Find("DeathTrigger");
        destination = new Vector3(Random.Range(-0.25f, 0.25f), Random.Range(-0.05f, 0.05f), 1);
    }
    void FixedUpdate()
    {        
        float speed = Random.Range(7f, 12f);
        transform.position -= destination * Time.deltaTime * speed;        
    }

    private void OnTriggerEnter(Collider other)
    {
        deathCanvas.GetComponent<Death>().DoDeath();
    }
}
