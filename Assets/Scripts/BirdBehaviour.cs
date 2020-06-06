using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviour : MonoBehaviour
{
    
    void Start()
    {
       
    }

    void Update()
    {
        float speed = Random.Range(5f, 10f);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(11, 6, -30), speed * Time.deltaTime);
    }
}
