using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public Vector2 lastCheckpointPos;
    private Respawn _respawn;

    void Start()
    {
        _respawn = GameObject.FindGameObjectWithTag("Player").GetComponent<Respawn>();
        _respawn.transform.position = lastCheckpointPos;
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
}
