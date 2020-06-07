using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class GameRules : MonoBehaviour
{
    public GameObject start, finish, player;
    float levelDistance, currentPosition;
    int levelProgression;

    public Slider progressLevel;

    void Start()
    {
        levelDistance = finish.transform.position.x - start.transform.position.x;        
    }

    void Update()
    {
        currentPosition = player.transform.position.x - start.transform.position.x;
        levelProgression = (int)(levelDistance / 100.0f * currentPosition * 2); //TODO check this
        progressLevel.value = levelProgression / 100.0f;
    }
}
