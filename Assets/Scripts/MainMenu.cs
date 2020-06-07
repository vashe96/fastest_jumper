using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Update()
    {
        if (PlayerPrefs.GetInt("audio") == 0)
            ;
        else;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1); 
    }

    public void SetAudio()
    {
        if (PlayerPrefs.GetInt("audio") == 0)
            PlayerPrefs.SetInt("audio", 1);
        else
            PlayerPrefs.SetInt("audio", 0);
    }
}
