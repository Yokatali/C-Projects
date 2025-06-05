using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    
    public Player1 player;
    private void Update()
    {
        if (player.isAppleCollected)
        {
            var direction = (player.transform.position - transform.position).normalized;
            transform.position += direction * Time.deltaTime * speed;
        }
    }

    public void StopEnemies()
    {
        speed = 0;
    }
}
