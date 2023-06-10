using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Vector2 startPosition;
    private Rigidbody2D rb;
    private GameManager _gameManager;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Spike")
        {
            RespawnFunc();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Death")
        {
            RespawnFunc();
        }
    }

    void RespawnFunc()
    {
        if (_gameManager.lastCheckpointPos != startPosition)
        {
            transform.position = _gameManager.lastCheckpointPos;
        }
        else
        {
            transform.position = startPosition;
        }
        rb.velocity = Vector2.zero;
    }
}
