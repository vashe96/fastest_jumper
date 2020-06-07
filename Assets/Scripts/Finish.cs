using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    string currentScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            SetProgression();
            SceneManager.LoadScene(1);
        }
    }

    void SetProgression()
    {
        currentScene = SceneManager.GetActiveScene().name;

        switch(currentScene)
        {
            case "Level 1":
                if (PlayerPrefs.GetInt("LevelPassed") < 1)
                    PlayerPrefs.SetInt("LevelPassed", 1);
                break;
            case "Level 2":
                if (PlayerPrefs.GetInt("LevelPassed") < 2)
                    PlayerPrefs.SetInt("LevelPassed", 2);
                break;
            case "Level 3":
                if (PlayerPrefs.GetInt("LevelPassed") < 3)
                    PlayerPrefs.SetInt("LevelPassed", 3);
                break;
            case "Level 4":
                if (PlayerPrefs.GetInt("LevelPassed") < 4)
                    PlayerPrefs.SetInt("LevelPassed", 4);
                break;
            case "Level 5":
                if (PlayerPrefs.GetInt("LevelPassed") < 5)
                    PlayerPrefs.SetInt("LevelPassed", 5);
                break;
            case "Level 6":
                if (PlayerPrefs.GetInt("LevelPassed") < 6)
                    PlayerPrefs.SetInt("LevelPassed", 6);
                break;
            case "Level 7":
                if (PlayerPrefs.GetInt("LevelPassed") < 7)
                    PlayerPrefs.SetInt("LevelPassed", 7);
                break;
            case "Level 8":
                if (PlayerPrefs.GetInt("LevelPassed") < 8)
                    PlayerPrefs.SetInt("LevelPassed", 8);
                break;
            case "Level 9":
                if (PlayerPrefs.GetInt("LevelPassed") < 9)
                    PlayerPrefs.SetInt("LevelPassed", 9);
                break;
            case "Level 10":
                if (PlayerPrefs.GetInt("LevelPassed") < 10)
                    PlayerPrefs.SetInt("LevelPassed", 10);
                break;
            case "Level 11":
                if (PlayerPrefs.GetInt("LevelPassed") < 11)
                    PlayerPrefs.SetInt("LevelPassed", 11);
                break;
            case "Level 12":
                if (PlayerPrefs.GetInt("LevelPassed") < 12)
                    PlayerPrefs.SetInt("LevelPassed", 12);
                break;
        }
    }
}
