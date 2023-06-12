using UnityEngine;
using TMPro;

public class ScoreUpdate : MonoBehaviour
{
    private static int scorePoints = 0;
    public TMP_Text scoreText;

    void Start()
    {
        scoreText.text = "Score: " + scorePoints;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            scorePoints += 100;
            scoreText.text = "Score: " + scorePoints;
            Debug.Log("Score: " + scorePoints);
            Destroy(gameObject);
        }
    }
}
