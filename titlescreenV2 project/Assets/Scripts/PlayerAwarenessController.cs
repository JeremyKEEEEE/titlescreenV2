using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwarenessController : MonoBehaviour
{
    public bool AwareIfPlayer {get; private set;}
    public Vector2 DirectionToPlayer {get; private set;}
    [SerializeField]
    private float _playerAvarenessDistance;
    private Transform _player;
    // Start is called before the first frame update
    private void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVector.normalized;
    
    }
}
