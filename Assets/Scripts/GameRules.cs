using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRules : MonoBehaviour
{
    public GameObject start, finish, player;
    float levelDistance, currentPosition;
    int levelProgression;

    public Image progressLevel;

    void Start()
    {
        levelDistance = finish.transform.position.x - start.transform.position.x - 3f;        
    }

    void Update()
    {
        currentPosition = player.transform.position.x - start.transform.position.x;
        levelProgression = (int)(levelDistance / 100.0f * currentPosition * 2); //TODO check this
        progressLevel.fillAmount = levelProgression / 100.0f;
    }
}
