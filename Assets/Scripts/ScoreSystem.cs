using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    string scoreKey = "Score";
    public int CurrentScore { get; set; } = 0;

    void Awake()
    {
        CurrentScore = PlayerPrefs.GetInt(scoreKey);
    }

    void Start()
    {
        CurrentScore = 0;
    }

    public void SetScore(int score)
    {
        PlayerPrefs.SetInt(scoreKey, score);
    }
}
