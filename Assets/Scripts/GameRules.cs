using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRules : MonoBehaviour
{
    public GameObject canvasText;
    public GameObject start, finish, player;
    float levelDistance, currentPosition;
    int levelProgression;

    void Start()
    {
        levelDistance = finish.transform.position.x - start.transform.position.x;
        
    }

    void Update()
    {
        currentPosition = player.transform.position.x - start.transform.position.x;
        levelProgression = (int)(levelDistance / 100.0f * currentPosition * 2);
        canvasText.GetComponent<Text>().text = levelProgression.ToString();
    }
}
