using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    public GameObject pauseCanvas;
   
    public void SetPause()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void SetUnpause()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }    
}
