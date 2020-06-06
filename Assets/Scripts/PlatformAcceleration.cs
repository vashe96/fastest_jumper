using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAcceleration : MonoBehaviour
{
    GameObject player;
    public string type;

    Rigidbody playerRB;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); 
        playerRB = player.GetComponent<Rigidbody>();        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            switch (type)
            {
                case "fast":
                    playerRB.velocity = new Vector3(0, 30, 0);
                    break;
                case "medium":
                    playerRB.velocity = new Vector3(0, 25, 0);
                    break;
                case "slow":
                    playerRB.velocity = new Vector3(0, 20, 0);
                    break;
            }            
        }
    }   
}
