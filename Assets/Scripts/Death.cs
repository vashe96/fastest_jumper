using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    GameObject player;
    PlayerController spawn;
    public GameObject mainCanvas;
    public GameObject canvas;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawn = player.GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        DoDeath();
    }

    public void DoDeath()
    {
        Time.timeScale = 0;
        mainCanvas.SetActive(false);
        canvas.SetActive(true);
    }
    public void AdWatched()
    {
        Time.timeScale = 1;
        player.transform.position = spawn.spawnPoint;
    }
}
