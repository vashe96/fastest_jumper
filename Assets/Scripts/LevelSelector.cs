using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12;
    public Sprite b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12;
    private void Start()
    {
        SetActiveButtons();
    }

    private void Update()
    {
        CheckBackButton();
    }

    public void SetFirstLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void SetSecondLevel()
    {
        SceneManager.LoadScene(3);
    }
    public void SetThirdLevel()
    {
        SceneManager.LoadScene(4);
    }
    public void SetFourthLevel()
    {
        SceneManager.LoadScene(5);
    }
    public void SetFifthLevel()
    {
        SceneManager.LoadScene(6);
    }
    public void SetSixthLevel()
    {
        SceneManager.LoadScene(7);
    }
    public void SetSeventhLevel()
    {
        SceneManager.LoadScene(8);
    }
    public void SetEighthLevel()
    {
        SceneManager.LoadScene(9);
    }
    public void SetNinthLevel()
    {
        SceneManager.LoadScene(10);
    }
    public void SetTenthLevel()
    {
        SceneManager.LoadScene(11);
    }
    public void SetEleventhLevel()
    {
        SceneManager.LoadScene(12);
    }
    public void SetTwelfthLevel()
    {
        SceneManager.LoadScene(13);
    }

    public void SetActiveButtons()
    {
        if (PlayerPrefs.GetInt("LevelPassed") >= 1)
        { 
            button2.interactable = true;
            button2.GetComponent<Image>().sprite = b2;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 2)
        { 
            button3.interactable = true; 
            button3.GetComponent<Image>().sprite = b3;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 3)
        { 
            button4.interactable = true;
            button4.GetComponent<Image>().sprite = b4;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 4)
        { 
            button5.interactable = true; 
            button5.GetComponent<Image>().sprite = b5;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 5)
        { 
            button6.interactable = true; 
            button6.GetComponent<Image>().sprite = b6;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 6)
        { 
            button7.interactable = true; 
            button7.GetComponent<Image>().sprite = b7;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 7)
        { 
            button8.interactable = true; 
            button8.GetComponent<Image>().sprite = b8;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 8)
        { 
            button9.interactable = true; 
            button9.GetComponent<Image>().sprite = b9;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 9)
        {
            button10.interactable = true;
            button10.GetComponent<Image>().sprite = b10;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 10)
        {
            button11.interactable = true;
            button11.GetComponent<Image>().sprite = b11;
        }

        if (PlayerPrefs.GetInt("LevelPassed") >= 11)
        { 
            button12.interactable = true; 
            button12.GetComponent<Image>().sprite = b12;
        }
    }

    void CheckBackButton()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
