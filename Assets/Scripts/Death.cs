using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    GameObject player;
    PlayerController spawn;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        spawn = player.GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        DoDeath();
    }

    public void DoDeath()
    {
        player.transform.position = spawn.spawnPoint;
    }
}
