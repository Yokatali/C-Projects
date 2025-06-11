using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Player player;
    public List<Enemy> enemies;
    public Enemy enemyPrefab;

    public Vector2 enemyCount;

    public void RestartEnemyManagaer()
    {
        DeleteEnemies();
        GenerateEnemies();
    }

    private void GenerateEnemies()
    {
        var randomEnemyCount = UnityEngine.Random.Range(enemyCount.x, enemyCount.y);
        for (int i = 0; i < randomEnemyCount; i++)
        {
            var enemyXPos = UnityEngine.Random.Range(2.3f, 10f);;
            var newEnemy = Instantiate(enemyPrefab);
            newEnemy.transform.position = new Vector3(enemyXPos, 0, -5 + i * 1.5f);
            enemies.Add(newEnemy);
            newEnemy.StartEnemy(player);
        }
    }

    private void DeleteEnemies()
    {
        foreach (var e in enemies)
        {
            Destroy(e.gameObject);
        }
        enemies.Clear();
    }

    public void StopEnemies()
    {
        foreach (var e in enemies)
        {
            e.StopEnemies();
        }
    }
}
