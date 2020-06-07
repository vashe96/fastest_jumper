using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdBehaviour : MonoBehaviour
{
    GameObject deathCanvas;

    private void Start()
    {
        deathCanvas = GameObject.Find("DeathTrigger");
    }
    void Update()
    {
        float speed = Random.Range(7f, 12f);
        transform.position += transform.forward * Time.deltaTime * speed;        
    }

    private void OnTriggerEnter(Collider other)
    {
        deathCanvas.GetComponent<Death>().DoDeath();
    }
}
