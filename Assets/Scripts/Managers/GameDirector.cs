using System;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [Header("Managers")]
    public EnemyManager enemyManager;
    public LevelManager levelManager;

    private void Start()
    {
        levelManager.RestartLevel();
    }

    public void levelComplated()
    {
        enemyManager.StopEnemies();
    }
}
