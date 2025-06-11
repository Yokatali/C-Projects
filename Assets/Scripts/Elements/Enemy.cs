using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Player _player;
    private Rigidbody _rb;
    public UnityEngine.AI.NavMeshAgent navMeshAgent;

    public void StartEnemy(Player player)
    {
        _player = player;
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_player.isAppleCollected)
        {
            /*var direction = (_player.transform.position - transform.position).normalized;
            direction.y = 0;
            _rb.transform.position += direction * Time.deltaTime * speed;*/
            
            navMeshAgent.destination = _player.transform.position;
        }
    }

    public void StopEnemies()
    {
        navMeshAgent.speed = 0;
    }
}
