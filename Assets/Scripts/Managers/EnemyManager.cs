using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Player1 player;
    public List<Enemy> enemies;
    public Enemy enemyPrefab;

    public int enemyCount;

    public void RestartEnemyManagaer()
    {
        DeleteEnemies();
        GenerateEnemies();
    }

    private void GenerateEnemies()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            var enemyXPos = 0f;
            enemyXPos = Random.Range(-2.5f, 2.5f);
            var newEnemy = Instantiate(enemyPrefab);
            newEnemy.transform.position = new Vector3(5, 0, -6 + i * 1.5f);
            enemies.Add(newEnemy);
            newEnemy.StartEnemy(player);
        }
    }

    private void DeleteEnemies()
    {
        
    }

    public void StopEnemies()
    {
        foreach (var e in enemies)
        {
            e.StopEnemies();
        }
    }
}
