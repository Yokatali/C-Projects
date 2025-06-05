using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<Enemy> enemies;

    public void StopEnemies()
    {
        foreach (var e in enemies)
        {
            e.StopEnemies();
        }
    }
}
