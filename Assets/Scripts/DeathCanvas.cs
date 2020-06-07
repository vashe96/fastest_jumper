using System.Collections;
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

    Death death;

    private void Awake()
    {
        death = gameObject.AddComponent<Death>();
        currentScene = SceneManager.GetActiveScene().name;

        player = GameObject.FindGameObjectWithTag("Player");
        spawn = player.GetComponent<PlayerController>();
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentScene);
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void Ads()
    {        
        mainCanvas.SetActive(true);
        canvas.SetActive(false);
        player.transform.position = spawn.spawnPoint;
        death.AdWatched();
    }          
        
}
