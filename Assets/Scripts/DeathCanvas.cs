﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCanvas : MonoBehaviour
{
    string currentScene;

    GameObject player;
    PlayerController spawn;
    public GameObject mainCanvas;
    public GameObject canvas;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().name;

        player = GameObject.FindGameObjectWithTag("Player");
        spawn = player.GetComponent<PlayerController>();
    }
    public void Restart()
    {
        SceneManager.LoadScene(currentScene);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Ads()
    {
        mainCanvas.SetActive(true);
        canvas.SetActive(false);
        player.transform.position = spawn.spawnPoint;
    }          
        
}
