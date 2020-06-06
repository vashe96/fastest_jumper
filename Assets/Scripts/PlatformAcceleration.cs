using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAcceleration : MonoBehaviour
{
    public PlayerController player;
    public string type;

    Rigidbody playerRB;
    void Start()
    {
        playerRB = player.GetComponent<Rigidbody>();        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            playerRB.velocity = new Vector3(0, 30, 0);
        }
    }   
}
