using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTrigger : MonoBehaviour
{

    private Rigidbody2D playerRb;
    ScoreSystem scoreSystem;
    private GameManager _gameManager;

    void Start()
    {
        playerRb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        scoreSystem = FindObjectOfType<ScoreSystem>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            scoreSystem.SetScore(GameManager.scorePoints);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
