using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button soundButton;

    public Sprite On;
    public Sprite Off;
    private void Update()
    {
        ChangeButton();
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

    void ChangeButton()
    {
        if (PlayerPrefs.GetInt("audio") == 0)
            soundButton.GetComponent<Image>().sprite = Off;
        else
            soundButton.GetComponent<Image>().sprite = On;
    }
}
