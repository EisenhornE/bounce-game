using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreUpdate : MonoBehaviour
{
    private static int _scorePoints = 0;
    private TMP_Text _scoreText;

    void Start()
    {
        _scoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
        _scoreText.text = "Score: " + _scorePoints;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _scorePoints += 100;
            _scoreText.text = "Score: " + _scorePoints;
            Debug.Log("Score: " + _scorePoints);
            Destroy(gameObject);
        }
    }
}
