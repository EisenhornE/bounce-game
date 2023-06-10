using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameManager _gameManager;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _gameManager.lastCheckpointPos = transform.position;
            ChangeCheckpointColor();
        }
    }

    void ChangeCheckpointColor()
    {
        _spriteRenderer.color = HexToColor("#00FFFF");
    }

    Color HexToColor(string hexCode)
    {
        Color color;
        if (ColorUtility.TryParseHtmlString(hexCode, out color))
        {
            return color;
        }
        else
        {
            Debug.LogWarning("Invalid Hex Code: " + hexCode);
            return Color.white;
        }
    }
}
