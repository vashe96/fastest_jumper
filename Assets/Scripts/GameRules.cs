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
        levelDistance = (finish.transform.position.x - start.transform.position.x) / 100;        
    }

    void Update()
    {
        currentPosition = (player.transform.position.x - start.transform.position.x) / 100;
        levelProgression = (int)(currentPosition / levelDistance * 100);
        progressLevel.value = levelProgression / 100.0f;
    }
}
