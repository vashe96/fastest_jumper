using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    GameObject player;
    PlayerController spawn;
    public GameObject canvas;

    DeathCanvas deathCanvas;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawn = player.GetComponent<PlayerController>();
        deathCanvas = new DeathCanvas();
    }
    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
    }

    public void DoDeath()
    {
        player.transform.position = spawn.spawnPoint;
    }
}
