using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{

    private GameManager _gameManager;

    void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        _gameManager.AddScore(100);
    }
}
