using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathCanvas : MonoBehaviour
{
    string currentScene;

    GameObject player;
    PlayerController spawn;
    public GameObject mainCanvas;
    public GameObject canvas;

    

    Death death;
    GameObject adsController;

    public Button ads;
    public Sprite On;
    public Sprite Off;

    bool adReady;

    private void Awake()
    {
        adsController = GameObject.Find("AdsController");
        death = gameObject.AddComponent<Death>();
        currentScene = SceneManager.GetActiveScene().name;

        player = GameObject.FindGameObjectWithTag("Player");
        spawn = player.GetComponent<PlayerController>();
    }

    private void Update()
    {
        adReady = adsController.GetComponent<Ads>().isRewardedVideoReady(); 
        if (adReady)
        { 
            ads.interactable = true;
            ads.GetComponent<Image>().sprite = On;
        }
        else
        {
            ads.GetComponent<Image>().sprite = Off;
            ads.interactable = false;
        }
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
        if (adReady)
        {
            adsController.GetComponent<Ads>().PlayRewardedVideoAd();
            Time.timeScale = 0;
        }
        mainCanvas.SetActive(true);
        canvas.SetActive(false);
        player.transform.position = spawn.spawnPoint;
        death.AdWatched();           
    }           
}
