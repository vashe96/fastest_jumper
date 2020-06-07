using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        DoDeath();
    }

    public void DoDeath()
    {
        SceneManager.LoadScene("SampleScene"); //TODO Death
    }
}
