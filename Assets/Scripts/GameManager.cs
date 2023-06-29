using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public Vector2 lastCheckpointPos;
    private Respawn _respawn;
    private static int _scorePoints = 0;
    private TMP_Text _scoreText;

    void Start()
    {
        _respawn = GameObject.FindGameObjectWithTag("Player").GetComponent<Respawn>();
        _respawn.transform.position = lastCheckpointPos;
        _scoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
        _scoreText.text = "Score: " + _scorePoints;
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
        _scorePoints += points;
        _scoreText.text = "Score: " + _scorePoints;
        Destroy(GameObject.FindGameObjectWithTag("Score"));
        Debug.Log("Score: " + _scorePoints);
    }
}
