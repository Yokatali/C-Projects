using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Player _player;
    private Rigidbody _rb;
    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    private Animator _animator;

    private bool _isWalking;

    public void StartEnemy(Player player)
    {
        _player = player;
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponentInChildren<Animator>();
    }
    
    
    
    private void Update()
    {
        if (_player.isAppleCollected)
        {
            /*var direction = (_player.transform.position - transform.position).normalized;
            direction.y = 0;
            _rb.transform.position += direction * Time.deltaTime * speed;*/
            
            navMeshAgent.destination = _player.transform.position;
            if (!_isWalking)
            {
                _isWalking = true;
                _animator.SetTrigger("Walk");
            }
        }
    }

    public void StopEnemies()
    {
        navMeshAgent.speed = 0;
        _animator.SetTrigger("Idle");
    }
}
