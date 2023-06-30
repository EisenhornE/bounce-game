using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public Vector2 lastCheckpointPos;
    private Respawn _respawn;
    public static int scorePoints;
    private TMP_Text _scoreText;
    ScoreSystem scoreSystem;

    void Start()
    {
        scorePoints = 0;
        _respawn = GameObject.FindGameObjectWithTag("Player").GetComponent<Respawn>();
        _respawn.transform.position = lastCheckpointPos;
        scoreSystem = FindObjectOfType<ScoreSystem>();
        scorePoints = GameObject.Find("ScoreSystem").GetComponent<ScoreSystem>().CurrentScore;
        _scoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
        _scoreText.text = "Score: " + scorePoints;
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int points)
    {
        scorePoints += points;
        _scoreText.text = "Score: " + scorePoints;
        Destroy(GameObject.FindGameObjectWithTag("Score"));
        Debug.Log("Score: " + scorePoints);
    }
}
