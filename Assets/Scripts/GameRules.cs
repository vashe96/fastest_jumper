using UnityEngine;
using UnityEngine.UI;

public class GameRules : MonoBehaviour
{
    public GameObject start, finish, player;
    float levelDistance, currentPosition;
    int levelProgression;

    public Slider progressLevel;
    GameObject adsController;

    void Start()
    {        
        adsController = GameObject.Find("AdsController");
        PlayAd();
        levelDistance = (finish.transform.position.x - start.transform.position.x) / 100;        
    }

    void Update()
    {        
        int a = PlayerPrefs.GetInt("Respawns");
        Debug.Log(a.ToString());        
        currentPosition = (player.transform.position.x - start.transform.position.x) / 100;
        levelProgression = (int)(currentPosition / levelDistance * 100);
        progressLevel.value = levelProgression / 100.0f;
    }

    void PlayAd()
    {
        if ((PlayerPrefs.GetInt("Respawns") % 5) == 0 && 
            (PlayerPrefs.GetInt("Respawns") > 0))
        {
            if (adsController.GetComponent<Ads>().isInterstitialReady())
                adsController.GetComponent<Ads>().PlayInterstitialAd();
        }
        int temp = PlayerPrefs.GetInt("Respawns");
        ++temp;
        PlayerPrefs.SetInt("Respawns", temp);
    }
    
}
