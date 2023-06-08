using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Color startColor = Color.red;
    public Color collisionColor = Color.yellow;

    private SpriteRenderer rend;
    private bool hasCollided = false;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.color = startColor;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !hasCollided)
        {
            hasCollided = true;
            rend.color = collisionColor;
            Debug.Log("Checkpoint!");
        }
    }
}
