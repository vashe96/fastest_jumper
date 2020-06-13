using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public Image Background;
    public Sprite Tutorial1, Tutorial2, Tutorial3;
    public void Tutorial()
    {
        if (Background.sprite == Tutorial1)
        {
            Background.sprite = Tutorial2;
        }
        else if (Background.sprite == Tutorial2)
        {
            Background.sprite = Tutorial3;
        }              
        else if(Background.sprite == Tutorial3)
        {
            PlayerPrefs.SetInt("TutorialWatched", 1);
            SceneManager.LoadScene(1);
        }
    }
}
