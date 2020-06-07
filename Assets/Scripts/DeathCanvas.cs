using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCanvas : MonoBehaviour
{
    Death death;
    string currentScene;
    private void Awake()
    {
        death = new Death();
        currentScene = SceneManager.GetActiveScene().name;
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
        death.DoDeath();
    }          
        
}
