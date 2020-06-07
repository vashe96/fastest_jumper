using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12;
    private void Start()
    {
        SetActiveButtons();
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
        if (PlayerPrefs.GetInt("LevelPassed") > 0)
            button2.interactable = true; 
        if (PlayerPrefs.GetInt("LevelPassed") > 1)
            button3.interactable = true;
        if (PlayerPrefs.GetInt("LevelPassed") > 2)
            button4.interactable = true;
        if (PlayerPrefs.GetInt("LevelPassed") > 3)
            button5.interactable = true;
        if (PlayerPrefs.GetInt("LevelPassed") > 4)
            button6.interactable = true;
        if (PlayerPrefs.GetInt("LevelPassed") > 5)
            button7.interactable = true;
        if (PlayerPrefs.GetInt("LevelPassed") > 6)
            button8.interactable = true;
        if (PlayerPrefs.GetInt("LevelPassed") > 7)
            button9.interactable = true;
        if (PlayerPrefs.GetInt("LevelPassed") > 8)
            button10.interactable = true;
        if (PlayerPrefs.GetInt("LevelPassed") > 9)
            button11.interactable = true;
        if (PlayerPrefs.GetInt("LevelPassed") > 10)
            button12.interactable = true;
    }
}
