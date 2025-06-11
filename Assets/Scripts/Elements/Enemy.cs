using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Player1 _player;

    public void StartEnemy(Player1 player)
    {
        _player = player;
    }

    private void Update()
    {
        if (_player.isAppleCollected)
        {
            var direction = (_player.transform.position - transform.position).normalized;
            transform.position += direction * Time.deltaTime * speed;
        }
    }

    public void StopEnemies()
    {
        speed = 0;
    }
}
